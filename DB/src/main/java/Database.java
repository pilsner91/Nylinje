import IMPL.ShelfServiceIMPL;
import io.grpc.Server;
import io.grpc.ServerBuilder;

import java.io.IOException;

public class Database {
    public static void main(String[] args) throws IOException, InterruptedException {
        Server server = ServerBuilder.forPort(9090).addService(new ShelfServiceIMPL()).build();
        server.start();
        server.awaitTermination();
    }

}
