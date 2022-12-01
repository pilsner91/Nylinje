import GRPCMethodCall.GRPCDataBase;
import io.grpc.Server;
import io.grpc.ServerBuilder;
//import net.devh.boot.grpc.server.service.GrpcService;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;


import java.io.IOException;

public class Database {
    public static void main(String[] args) throws Exception{
        Server server = ServerBuilder.forPort(9090)
                .addService(new GRPCDataBase())
                .build();
        server.start();
        server.awaitTermination();


    }

}
