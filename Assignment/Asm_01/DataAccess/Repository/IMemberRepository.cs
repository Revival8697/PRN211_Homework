using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> findAll();
        MemberObject findById(string id);

        MemberObject findByIdAndName(string id, string name);

        IEnumerable<MemberObject> filterByCountryAndCity(string country, string city);
        void insert(MemberObject member);

        void remove(string id);
        void update(MemberObject member);

    }
}
