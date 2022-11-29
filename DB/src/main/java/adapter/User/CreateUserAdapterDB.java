package adapter.User;

import Domain.Model.User;
import GRPC.proto.File;
import database.DaoInterface.IUserDao;

public class CreateUserAdapterDB
{

    public CreateUserAdapterDB() {
    }

    public File.User CreateUser(File.User user){

        return File.User.newBuilder()
                .setId(user.getId())
                .build();


    }


}
