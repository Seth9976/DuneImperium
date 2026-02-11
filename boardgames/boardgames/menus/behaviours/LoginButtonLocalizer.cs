using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.menus.behaviours
{
	// Token: 0x02000153 RID: 339
	public class LoginButtonLocalizer : MonoBehaviour
	{
		// Token: 0x06001153 RID: 4435 RVA: 0x000462D4 File Offset: 0x000444D4
		// Note: this type is marked as 'beforefieldinit'.
		static LoginButtonLocalizer()
		{
			Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus.behaviours", "LoginButtonLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr);
			LoginButtonLocalizer.NativeFieldInfoPtr_loggedOutKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr, "loggedOutKey");
			LoginButtonLocalizer.NativeFieldInfoPtr_loggedInKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr, "loggedInKey");
			LoginButtonLocalizer.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr, 100665841);
			LoginButtonLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr, 100665842);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00046354 File Offset: 0x00044554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999925, XrefRangeEnd = 999926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Substitute(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginButtonLocalizer.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0004639C File Offset: 0x0004459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999926, XrefRangeEnd = 999932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginButtonLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginButtonLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginButtonLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0000A1B3 File Offset: 0x000083B3
		public LoginButtonLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000463D8 File Offset: 0x000445D8
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0000A1BC File Offset: 0x000083BC
		public unsafe string loggedOutKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginButtonLocalizer.NativeFieldInfoPtr_loggedOutKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginButtonLocalizer.NativeFieldInfoPtr_loggedOutKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00046400 File Offset: 0x00044600
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0000A1DB File Offset: 0x000083DB
		public unsafe string loggedInKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginButtonLocalizer.NativeFieldInfoPtr_loggedInKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginButtonLocalizer.NativeFieldInfoPtr_loggedInKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_loggedOutKey;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_loggedInKey;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
