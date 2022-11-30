package adapter.User;

import Domain.Model.User;
import GRPC.proto.File;
import database.DaoInterface.IUserDao;

public class CreateUserAdapterDB
{
    private IUserDao UserDao;

    public CreateUserAdapterDB(IUserDao UserDao) {
        this.UserDao = UserDao;
    }

    public File.UserProto CreateUser(File.UserProto userProto){
        User user = new User(userProto
                .getId());

        User result =UserDao.CreateUser(user);

        File.UserProto newUserProto = File.UserProto.newBuilder()
                .setId(result.getId())
                .build();

        return newUserProto;
    }


}
