using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
   public interface Irepository<T> where T: BaseEntity
    {
        //List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifies();

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);


        void Delete(T item);
        void DeleteRange(List<T> list);


        void Update(T item);
        void UpdateRange(List<T> list);


        void Destroy(T item);
        void DestroyRange(List<T> list);


        //Linq Commands
        List<T> Where(Expression<Func<T,bool>>exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T,bool>>exp);
        object Select(Expression<Func<T,object>>exp);



        //Find Commands
        T Find(int id);


        //Custom Commands

        T GetLastData();
        T GetFirstData();
    }
}
