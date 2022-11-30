package database.DaoInterface;

import Domain.Model.User;
import GRPC.proto.File;

public interface IUserDao {

    User CreateUser(User dto);


}


