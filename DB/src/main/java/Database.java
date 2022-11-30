
import io.grpc.Server;
import io.grpc.ServerBuilder;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.IOException;

@SpringBootApplication
public class Database {
    public static void main(String[] args) throws IOException, InterruptedException {
        Server server = ServerBuilder
                .forPort(9090)
                //.addService(new ShelfServiceIMPL())
                //.addService(new ItemServiceImpl())
                .build();

        server.start();
        server.awaitTermination();
    }

}
