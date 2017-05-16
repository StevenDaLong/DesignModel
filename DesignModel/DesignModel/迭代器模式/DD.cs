using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
迭代器模式：

优点：
    迭代器模式使得访问一个聚合对象的内容而无需暴露它的内部表示，即迭代抽象。
    迭代器模式为遍历不同的集合结构提供了一个统一的接口，从而支持同样的算法在不同的集合结构上进行操作
缺陷：
    迭代器模式在遍历的同时更改迭代器所在的集合结构会导致出现异常。所以使用foreach语句只能在对集合进行遍历，不能在遍历的同时更改集合中的元素。


*/
namespace DesignModel.DD
{
    public interface IList
    {
        IDieDai GetDiedai();
    }

    public interface IDieDai
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }

    public class List : IList
    {
        private int[] array;

        public List()
        {
            array = new int[] { 1, 2, 3, 4, 5 };
        }
        public IDieDai GetDiedai()
        {
            return new DieDai(this);
        }

        public int Count()
        {
            return array.Length;
        }

        public int GetCurrent(int index)
        {
            return array[index];
        }
    }

    public class DieDai : IDieDai
    {

        private List _a;
        private int _index;
        public DieDai(List list)
        {
            _a = list;
            _index = 0;
        }

        public object GetCurrent()
        {
            return _a.GetCurrent(_index);
        }

        public bool MoveNext()
        {
            return _index < _a.Count();
        }

        public void Next()
        {
            _index++;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
