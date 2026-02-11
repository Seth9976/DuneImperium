using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.events
{
	// Token: 0x02000083 RID: 131
	public class GameFinished : OfflineChallenges.Event
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x00025894 File Offset: 0x00023A94
		// Note: this type is marked as 'beforefieldinit'.
		static GameFinished()
		{
			Il2CppClassPointerStore<GameFinished>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.events", "GameFinished");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFinished>.NativeClassPtr);
			GameFinished.NativeFieldInfoPtr_youWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFinished>.NativeClassPtr, "youWon");
			GameFinished.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFinished>.NativeClassPtr, "points");
			GameFinished.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFinished>.NativeClassPtr, 100664386);
			GameFinished.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFinished>.NativeClassPtr, 100664387);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00025914 File Offset: 0x00023B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989186, XrefRangeEnd = 989187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameFinished(bool youWon, int points)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFinished>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref youWon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref points;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameFinished.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002596C File Offset: 0x00023B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989187, XrefRangeEnd = 989196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameFinished.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00004F56 File Offset: 0x00003156
		public GameFinished(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000259B0 File Offset: 0x00023BB0
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00004F5F File Offset: 0x0000315F
		public unsafe bool youWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameFinished.NativeFieldInfoPtr_youWon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameFinished.NativeFieldInfoPtr_youWon)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000259D8 File Offset: 0x00023BD8
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00004F7A File Offset: 0x0000317A
		public unsafe int points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameFinished.NativeFieldInfoPtr_points);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameFinished.NativeFieldInfoPtr_points)) = value;
			}
		}

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_youWon;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
