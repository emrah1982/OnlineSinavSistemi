using Microsoft.EntityFrameworkCore;
using OnlineSinavCore.Abstract;
using OnlineSinavCore.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace OnlineSinavCore.Concrete
{
    public class EFBaseRepository<TContext, TEntity> : IRepository<TEntity>
         where TEntity : class, IData, new()
        where TContext : DbContext, new()
    {
        TContext context;

        public EFBaseRepository(TContext _context)
        {
            context = _context;
        }


        public ResultMessage<TEntity> Add(TEntity data)
        {
            //using (var dbContextTransaction = context.Database.BeginTransaction())
            //{
            ExceptionHandlers.ExceptionHandler(() => {
                var addedData = context.Entry(data);
                addedData.State = EntityState.Added;
                data.IsActive = true;
                data.InsertDate = DateTime.Now;
                //dbContextTransaction.Commit();
                //return context.SaveChanges() > 0 ? new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veri başarılı bir şekilde kaydedildi" } : new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veriniz kaydedilemedi Lütfen daha Sonra Tekrar deneyiniz" };
               // var sonuc = context.SaveChanges() > 0 ? new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veri başarılı bir şekilde kaydedildi" } : new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veriniz kaydedilemedi Lütfen daha Sonra Tekrar deneyiniz" };
            });
            try
            {
                

                

            }
            catch (System.Exception ex)
            {
                //dbContextTransaction.Rollback();
                //ExceptionMessage.ExceptionMessageAdd(IExceptionMessage data,KullaniciId, ex);                      
                return new ResultMessage<TEntity> { IsSuccess = false, Message = ex.Message };

            }
            //}
            return new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veri başarılı bir şekilde kaydedildi." };
        }

        public ResultMessage<TEntity> AddRange(TEntity data)
        {
            using (var context = new TContext())
            {
                //using (var dbTransaction = context.Database.BeginTransaction())
                //{
                try
                {
                    context.AddRange(data);
                    //dbTransaction.Commit();
                    return context.SaveChanges() > 0 ? new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veri başarılı bir şekilde kaydedildi" } : new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veriniz kaydedilemedi Lütfen daha Sonra Tekrar deneyiniz" };
                }
                catch (System.Exception ex)
                {

                    //dbTransaction.Rollback();
                    return new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = ex.Message };
                }

                //}

            }
        }

        public ResultMessage<ICollection<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            List<TEntity> result;
            if (filter == null)
            {
                result = context.Set<TEntity>().ToList();
            }
            else
            {
                result = context.Set<TEntity>().Where(x => x.IsDeleted == true).Where(filter).ToList();
            }

            return new ResultMessage<ICollection<TEntity>> { Data = result, IsSuccess = true, Message = "Verileriniz Listelendi" };

        }

        public ResultMessage<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {

                TEntity data = context.Set<TEntity>().FirstOrDefault(filter);
                //ternary if
                return data == null ? new ResultMessage<TEntity> { IsSuccess = false, Message = "Aranan kriterlere uygun kayıt bulunamadı." } : new ResultMessage<TEntity> { IsSuccess = true, Message = "Kayıt getirildi.", Data = data };

            }
            catch (System.Exception ex)
            {
                return new ResultMessage<TEntity> { IsSuccess = false, Message = ex.Message };
            }
        }

        public ResultMessage<TEntity> Remove(TEntity data)
        {

            //using (var dbTransaction = context.Database.BeginTransaction())
            //{
            try
            {
                var removeData = context.Entry(data);
                data.IsDeleted = false;
                removeData.State = EntityState.Modified;
                //dbTransaction.Commit();
                return context.SaveChanges() > 0 ? new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Silindi" } : new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Silinmedi" };
            }
            catch (System.Exception ex)
            {

                //dbTransaction.Rollback();
                return new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = ex.Message };
            }
            //}



        }

        public ResultMessage<TEntity> Update(TEntity data)
        {

            //using (var dbTransaction = context.Database.BeginTransaction())
            //{
            try
            {
                var updateData = context.Entry(data);
                updateData.State = EntityState.Modified;
                data.UpdateDate = DateTime.UtcNow;
                //dbTransaction.Commit();
                //return context.SaveChanges() > 0 ? new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Güncellendi" } : new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Güncellenemedi" };
                return new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Güncellendi" } /*: new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Veriniz Güncellenemedi" }*/;
            }
            catch (System.Exception ex)
            {
                //dbTransaction.Rollback();
                return new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = ex.Message };
            }
        }

        public ResultMessage<TEntity> UpdateRange(TEntity data)
        {
            using (var context = new TContext())
            {
                //using (var dbTransaction = context.Database.BeginTransaction())
                //{
                try
                {
                    context.UpdateRange(data);
                    var updateData = context.Entry(data);
                    updateData.State = EntityState.Modified;
                    data.IsActive = true;
                    data.UpdateDate = DateTime.Now;
                    //dbTransaction.Commit();
                    return new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Verileriniz başarılı bir şekilde güncellendi" }/* : new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veriniz kaydedilemedi Lütfen daha Sonra Tekrar deneyiniz" }*/;
                }
                catch (System.Exception ex)
                {

                    //dbTransaction.Rollback();
                    return new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = ex.Message };
                }

                //}

            }
        }

        public ResultMessage<TEntity> RemoveRange(TEntity data)
        {
          
            using (var context = new TContext())
            {
                //using (var dbTransaction = context.Database.BeginTransaction())
                //{
                try
                {
                    //context.Configuration.AutoDetectChangesEnabled = false;//Otomatik algılamayı kapatmak için
                    //IList<TEntity> entities = new IList<TEntity>();
                    context.RemoveRange(data);
                    var removeData = context.Entry(data);
                    removeData.State = EntityState.Modified;

                
                    // 2. CALL DetectChanges before SaveChanges
                    //context.ChangeTracker.DetectChanges();
                    data.IsActive = false;
                    data.UpdateDate = DateTime.Now;
                    //dbTransaction.Commit();
                    return new ResultMessage<TEntity> { IsSuccess = true, Data = data, Message = "Verileriniz başarılı bir şekilde sillindi." }/* : new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = "Veriniz kaydedilemedi Lütfen daha Sonra Tekrar deneyiniz" }*/;
                }
                catch (System.Exception ex)
                {

                    //dbTransaction.Rollback();
                    return new ResultMessage<TEntity> { IsSuccess = false, Data = data, Message = ex.Message };
                }

                //}

            }
        }
               
    }
}
