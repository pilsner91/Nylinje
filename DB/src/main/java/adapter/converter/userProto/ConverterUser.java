package adapter.converter.userProto;

import Domain.Model.User;
import GRPC.proto.File.*;

public class ConverterUser
{
  public static UserProto User_To_UserProto(User user)
  {
    return UserProto.newBuilder()
        .setId(user.getId())
        .build();
  }
}