using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMMON
{
    public static class CommonCookie
    {
        public enum cookName { userCook = 0 }
        public enum CookValue { userID = 0, userName = 1, password = 2 }
    }
    public enum UserSession
    {


        BeginYear = 2015,
        ZoneId,
        DevisionId,
        RegionId,
        DepoId,
        AreaID,
        TerritoryID,
        MarketID,
        factoryID,
        UserId,
        UserName,
        Post,
        PostCategory,
        EmployeeId,
        SessionId,
        Pages,
        EmployementID,
        DepartmentID,
        DivisionID,
        SectionID,
        InHeadOffice,
        CenterID,
        UserTableID,
        ImagePath,
        UserPhoto,
        PhotoType,
        PostName
    }
    public enum MessageType { Success, Error, Info, Warning};

}
	