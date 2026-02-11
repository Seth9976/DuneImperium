using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x02000088 RID: 136
	public class WinAGame : BaseChallengeDefinition
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x00026160 File Offset: 0x00024360
		// Note: this type is marked as 'beforefieldinit'.
		static WinAGame()
		{
			Il2CppClassPointerStore<WinAGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.definitions", "WinAGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinAGame>.NativeClassPtr);
			WinAGame.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinAGame>.NativeClassPtr, 100664399);
			WinAGame.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinAGame>.NativeClassPtr, 100664400);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000261B8 File Offset: 0x000243B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989280, XrefRangeEnd = 989281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WinAGame(int id, string locKey, string icon, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinAGame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinAGame.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00026234 File Offset: 0x00024434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989281, XrefRangeEnd = 989284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinAGame.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000050A5 File Offset: 0x000032A5
		public WinAGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0;
	}
}
