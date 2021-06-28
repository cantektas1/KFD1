//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace KFD1.BLL.Concreate
//{
//    public class UserService : IUserService
//    {
//    private readonly IUnitofWork uow;
//    public UserService(IUnitofWork _uow)
//    {
//        uow = _uow;
//    }

//    public UserDTO CheckRegistration(string UserName, string EMail)
//   {
//         var checkUser = uow.GetRepository<User>().Get(z => (z.EMail == EMail || z.UserName == UserName));
//         return MapperFactory.CurrentMapper.Map<UserDTO>(checkUser);
//}
//          }
//}
