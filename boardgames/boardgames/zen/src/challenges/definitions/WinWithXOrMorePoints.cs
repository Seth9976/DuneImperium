using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x0200008A RID: 138
	public class WinWithXOrMorePoints : BaseChallengeDefinition
	{
		// Token: 0x060006D0 RID: 1744 RVA: 0x0002645C File Offset: 0x0002465C
		// Note: this type is marked as 'beforefieldinit'.
		static WinWithXOrMorePoints()
		{
			Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.definitions", "WinWithXOrMorePoints");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr);
			WinWithXOrMorePoints.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr, "points");
			WinWithXOrMorePoints.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr, 100664404);
			WinWithXOrMorePoints.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr, 100664405);
			WinWithXOrMorePoints.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr, 100664406);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000264DC File Offset: 0x000246DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989365, XrefRangeEnd = 989366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WinWithXOrMorePoints(int id, string locKey, string icon, int points, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinWithXOrMorePoints>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref points;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinWithXOrMorePoints.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00026564 File Offset: 0x00024764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989366, XrefRangeEnd = 989369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinWithXOrMorePoints.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000265BC File Offset: 0x000247BC
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989369, XrefRangeEnd = 989381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinWithXOrMorePoints.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000050D6 File Offset: 0x000032D6
		public WinWithXOrMorePoints(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00026600 File Offset: 0x00024800
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000050DF File Offset: 0x000032DF
		public unsafe int points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinWithXOrMorePoints.NativeFieldInfoPtr_points);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinWithXOrMorePoints.NativeFieldInfoPtr_points)) = value;
			}
		}

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_Int32_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
	}
}
