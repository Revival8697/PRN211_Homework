using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository

    {
        public IEnumerable<MemberObject> filterByCountryAndCity(string country, string city)
        {
            return MemberDAO.Instance.filterByCountryAndCity(country, city);
        }

        public IEnumerable<MemberObject> findAll()
        {
            return MemberDAO.Instance.findAll();
        }

        public MemberObject findById(string id)
        {
            return MemberDAO.Instance.findById(id);
        }

        public MemberObject findByIdAndName(string id, string name)
        {
            return MemberDAO.Instance.findByIdAndName(id, name);
        }

        public void insert(MemberObject member)
        {
            MemberDAO.Instance.insert(member);
        }

        public void remove(string id)
        {
            MemberDAO.Instance.remove(id);
        }

        public void update(MemberObject member)
        {
            MemberDAO.Instance.update(member);
        }
    }

}
