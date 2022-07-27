public class Vehicle {
string VehicleNumber;
string Name;
string Model;
int Year;
string Color;

public string getVehicleNumber() {
return VehicleNumber;
}

public void setVehicleNumber(string vehicleNumber) {
VehicleNumber = vehicleNumber;
}

public void setName(string name) {
Name = name;
}

public void setModel(string model) {
Model = model;
}

public void setYear(int year) {
Year = year;
}

public void setColor(string color) {
Color = color;
}

public string getName() {
return Name;
}

public string getModel() {
return Model;
}

public int getYear() {
return Year;
}

public string getColor() {
return Color;
}

}
interface User {
int getUserId();
string getUserName();
string getUserEmail();
string getUserPhone();
}
public class Drive extends Vehicle{
public void setMilage(){

}
}
public class Park extends Vehicle{
public void setMilage(){

}
}
public class Repair extends Vehicle{
public void setDescription(){

}
}
public class AssignVehicleToUser extends Vehicle implements User, SaveData{

@Override
public int getUserId() {
return 0;
}

@Override
public string getUserName() {
return null;
}

@Override
public string getUserEmail() {
return null;
}

@Override
public string getUserPhone() {
return null;
}

@Override
public void SavetoDatabase() {
getName();
getVehicleNumber();
getColor();
getModel();
getYear();
getUserId();
getUserName();
getUserEmail();
getUserPhone();
}


}
public class RemoveVehicleFromUser extends Vehicle implements User, SaveData{
@Override
public void SavetoDatabase() {

}

@Override
public int getUserId() {
return 0;
}

@Override
public string getUserName() {
return null;
}

@Override
public string getUserEmail() {
return null;
}

@Override
public string getUserPhone() {
return null;
}
}
interface CreateUser {
void setUserId();
void setUserName();
void setUserEmail();
void setUserPhone();
}
public interface SaveData {
public void SavetoDatabase();
}
