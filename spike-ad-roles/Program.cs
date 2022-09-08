using spike_ad_roles;

const string groupName = "PrepareForABDevTesting";

var memberUserIds = await GraphManager.GetGroupMemberUserIdsAsync(groupName);

Console.WriteLine();

Console.WriteLine("Member Count: {0}", memberUserIds.Count());
Console.WriteLine();

//TODO: This will fail due to access issues
var userDetails = await GraphManager.GetGroupMemberUserDetailsAsync(groupName);
Console.WriteLine("Count: {0}", userDetails.Count());
