using BusinessObject;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> members = new List<MemberObject>()
        {
            new MemberObject { MemberId = "1", MemberName = "a", Email = "test_1@email.com", Password = "123", City = "city_1", Country = "country_1"},
            new MemberObject { MemberId = "2", MemberName = "c", Email = "test_2@email.com", Password = "123", City = "city_1", Country = "country_2"},
            new MemberObject { MemberId = "3", MemberName = "b", Email = "test_3@email.com", Password = "123", City = "city_2", Country = "country_2"},
            new MemberObject { MemberId = "4", MemberName = "a", Email = "test_4@email.com", Password = "123", City = "city_2", Country = "country_1"},
        };
        private static MemberDAO memberDAO = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
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
        public List<MemberObject> findAll()
        { return members; }
        public List<MemberObject> findByIdAndName(string id, string name)
        {
            if (string.IsNullOrEmpty(id)) { return members.Where(m => m.MemberId.Equals(name)).ToList(); }
            else if (string.IsNullOrEmpty(name)) { return members.Where(m => m.MemberId.Equals(id)).ToList(); }
            else return members.Where(m => m.MemberId.Equals(name) && m.MemberId.Equals(id)).ToList();
        }
        public MemberObject findById(string id)
        { return members.Find(m => m.MemberId.Equals(id)); }
        public List<MemberObject> findByName(string name)
        { return members.Where(m => m.MemberId.Equals(name)).ToList(); }
        public List<MemberObject> filterByCountryAndCity(string country, string city)
        {
            if (string.IsNullOrEmpty(country)) { return members.Where(m => m.City.Equals(city)).ToList(); }
            else if (string.IsNullOrEmpty(city)) { return members.Where(m => m.Country.Equals(country)).ToList(); }
            else return members.Where(m => m.Country.Equals(country) && m.City.Equals(city)).ToList();
        }
        public List<MemberObject> filterByCountry(string country)
        { return members.Where(m => m.Country.Equals(country)).ToList(); }
        public List<MemberObject> filterByCity(string city)
        { return members.Where(m => m.City.Equals(city)).ToList(); }

        public void insert(MemberObject member)
        {
            MemberObject existedMember = findById(member.MemberId);
            if (existedMember != null)
            { throw new Exception("Member already existed!"); }
            else { members.Add(member); }
        }
        public void update(MemberObject member)
        {
            MemberObject exixtedMember = findById(member.MemberId);
            if (exixtedMember != null)
            {
                members[members.IndexOf(exixtedMember)] = member;
            }
            else { throw new Exception("Member not existed"); }
        }
        public void remove(string id)
        {
            MemberObject existedMember = findById(id);
            if (existedMember == null) throw new Exception("Member not existed");
            members.Remove(existedMember);
        }
    }
}
