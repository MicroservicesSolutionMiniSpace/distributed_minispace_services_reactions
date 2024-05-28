namespace MiniSpace.Services.Notifications.Core.Entities
{
    public enum NotificationEventType
    {
        NewFriendRequest,
        FriendRequestAccepted,
        NewEvent,
        EventDeleted,
        EventNewSignUp,
        EventNewSignUpFriend,
        StudentCancelledSignedUpToEvent,
        StudentShowedInterestInEvent,
        StudentCancelledInterestInEvent,
        EventParticipantAdded,
        EventParticipantRemoved,
        NewPost,
        MentionedInPost,
        EventReminder,
        Other
    }
}