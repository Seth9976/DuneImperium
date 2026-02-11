using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200035B RID: 859
	public static class PlayableOutputExtensions
	{
		// Token: 0x06002E8D RID: 11917 RVA: 0x000B5544 File Offset: 0x000B3744
		public static bool IsOutputNull<U>(U output) where U : struct
		{
			return output.GetHandle().IsNull();
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000B556C File Offset: 0x000B376C
		public static bool IsOutputValid<U>(U output) where U : struct
		{
			return output.GetHandle().IsValid();
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000B5594 File Offset: 0x000B3794
		public static Object GetReferenceObject<U>(U output) where U : struct
		{
			return output.GetHandle().GetReferenceObject();
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000B55BC File Offset: 0x000B37BC
		public static void SetReferenceObject<U>(U output, Object value) where U : struct
		{
			output.GetHandle().SetReferenceObject(value);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000B55E4 File Offset: 0x000B37E4
		public static Object GetUserData<U>(U output) where U : struct
		{
			return output.GetHandle().GetUserData();
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000B560C File Offset: 0x000B380C
		public static void SetUserData<U>(U output, Object value) where U : struct
		{
			output.GetHandle().SetUserData(value);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000B5634 File Offset: 0x000B3834
		public static Playable GetSourcePlayable<U>(U output) where U : struct
		{
			return new Playable(output.GetHandle().GetSourcePlayable());
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000B5660 File Offset: 0x000B3860
		public static void SetSourcePlayable<U, V>(U output, V value) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), PlayableOutputExtensions.GetSourceOutputPort<U>(output));
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000B5698 File Offset: 0x000B3898
		public static void SetSourcePlayable<U, V>(U output, V value, int port) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), port);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000B56CC File Offset: 0x000B38CC
		public static int GetSourceOutputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000B56F4 File Offset: 0x000B38F4
		public static float GetWeight<U>(U output) where U : struct
		{
			return output.GetHandle().GetWeight();
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000B571C File Offset: 0x000B391C
		public static void SetWeight<U>(U output, float value) where U : struct
		{
			output.GetHandle().SetWeight(value);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000B5744 File Offset: 0x000B3944
		public static void PushNotification<U>(U output, Playable origin, INotification notification, [Optional] Object context) where U : struct
		{
			output.GetHandle().PushNotification(origin.GetHandle(), notification, context);
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x000B5774 File Offset: 0x000B3974
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers<U>(U output) where U : struct
		{
			return output.GetHandle().GetNotificationReceivers();
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000B579C File Offset: 0x000B399C
		public static void AddNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().AddNotificationReceiver(receiver);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000B57C4 File Offset: 0x000B39C4
		public static void RemoveNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().RemoveNotificationReceiver(receiver);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000B57EC File Offset: 0x000B39EC
		public static int GetSourceInputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000129A5 File Offset: 0x00010BA5
		public static void SetSourceInputPort<U>(U output, int value) where U : struct
		{
			PlayableOutputExtensions.SetSourcePlayable<U, Playable>(output, PlayableOutputExtensions.GetSourcePlayable<U>(output), value);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000129B6 File Offset: 0x00010BB6
		public static void SetSourceOutputPort<U>(U output, int value) where U : struct
		{
			PlayableOutputExtensions.SetSourcePlayable<U, Playable>(output, PlayableOutputExtensions.GetSourcePlayable<U>(output), value);
		}
	}
}
