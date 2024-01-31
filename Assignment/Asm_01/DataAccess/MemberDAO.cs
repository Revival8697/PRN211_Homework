using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> members = new List<MemberObject>()
        {
            new MemberObject { MemberId = "1", MemberName = "a", Email = "test_1@email.com", Password = "123", City = "city_1", Country = "country_1"},
            new MemberObject { MemberId = "2", MemberName = "c", Email = "test_2@email.com", Password = "123", City = "city_1", Country = "country_2"},
            new MemberObject { MemberId = "3", MemberName = "b", Email = "test_3@email.com", Password = "123", City = "city_2", Country = "country_2"}
        };

        private static MemberDAO memberDAO=null;
        private static readonly object instanceLock = new object();
        private MemberDAO() {}
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (memberDAO == null) { memberDAO = new MemberDAO(); }
                    return memberDAO;
                }
            }
            
        }
        public void insert(MemberObject member)
        {
            MemberObject existedMember = findById(member.MemberId);
            if (existedMember != null) { throw new Exception("Member already exists!"); }
            else { members.Add(member); }
        }
        public List<MemberObject> findAll()
        {
            return members;
        }
        public MemberObject findById(string id)
        {
            return members.Find(m => m.MemberId.Equals(id));
        }
        public MemberObject findByIdAndName(string id, string name)
        {
            return members.Find(m => m.MemberId.Equals(id) && m.MemberName.Equals(name));
        }
        public List<MemberObject> filterByCountryAndCity(string country, string city)
        {
           var filterList = from m in members 
                            where m.Country == country && m.City == city
                            select m;

            return filterList.ToList();
        }
        public void update(MemberObject member)
        {
            MemberObject exixtedMember = findById(member.MemberId);
            if (exixtedMember != null) { members[members.IndexOf(exixtedMember)] = member; }
            else { throw new Exception("Member does not exist!"); }
        }
        public void remove(string id)
        {
            MemberObject existedMember = findById(id);
            if(existedMember == null) throw new Exception("Member does not exist!");
            members.Remove(existedMember);    
        }
    }
}