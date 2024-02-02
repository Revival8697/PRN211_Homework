using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> filterByCountryAndCity(string country, string city)
        { return MemberDAO.Instance.filterByCountryAndCity(country, city); }
        public IEnumerable<MemberObject> filterByCountry(string country)
        { return MemberDAO.Instance.filterByCountry(country); }
        public IEnumerable<MemberObject> filterByCity(string city)
        { return MemberDAO.Instance.filterByCity(city); }
        public IEnumerable<MemberObject> findAll()
        { return MemberDAO.Instance.findAll(); }
        public IEnumerable<MemberObject> findByIdAndName(string id, string name)
        { return MemberDAO.Instance.findByIdAndName(id, name); }
        public MemberObject findById(string id)
        { return MemberDAO.Instance.findById(id); }
        public IEnumerable<MemberObject> findByName(string name)
        { return MemberDAO.Instance.findByName(name); }
        public void insert(MemberObject member)
        { MemberDAO.Instance.insert(member); }
        public void remove(string id)
        { MemberDAO.Instance.remove(id); }
        public void update(MemberObject member)
        { MemberDAO.Instance.update(member); }
    }

}
