using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.match.render
{
	// Token: 0x02000299 RID: 665
	public class KeyGrip : MonoBehaviour
	{
		// Token: 0x06001F2E RID: 7982 RVA: 0x00085910 File Offset: 0x00083B10
		// Note: this type is marked as 'beforefieldinit'.
		static KeyGrip()
		{
			Il2CppClassPointerStore<KeyGrip>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.render", "KeyGrip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr);
			KeyGrip.NativeFieldInfoPtr_namedRigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, "namedRigs");
			KeyGrip.NativeFieldInfoPtr_currentRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, "currentRig");
			KeyGrip.NativeFieldInfoPtr__MainCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, "<MainCamera>k__BackingField");
			KeyGrip.NativeMethodInfoPtr_get_MainCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668525);
			KeyGrip.NativeMethodInfoPtr_set_MainCamera_Private_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668526);
			KeyGrip.NativeMethodInfoPtr_Register_Public_Void_String_NamedRigging_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668527);
			KeyGrip.NativeMethodInfoPtr_Unregister_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668528);
			KeyGrip.NativeMethodInfoPtr_ActivateRig_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668529);
			KeyGrip.NativeMethodInfoPtr_GetRig_Public_NamedRigging_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668530);
			KeyGrip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr, 100668531);
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00085A08 File Offset: 0x00083C08
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00085A48 File Offset: 0x00083C48
		public unsafe Camera MainCamera
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_get_MainCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_set_MainCamera_Private_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00085A8C File Offset: 0x00083C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540993, XrefRangeEnd = 541004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(string registeredName, NamedRigging rig, bool asDefault = false, Camera mainCamera = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(registeredName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rig);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asDefault;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_Register_Public_Void_String_NamedRigging_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00085B04 File Offset: 0x00083D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541004, XrefRangeEnd = 541008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(string registeredName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(registeredName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_Unregister_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00085B48 File Offset: 0x00083D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541008, XrefRangeEnd = 541019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRig(string rigName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rigName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_ActivateRig_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00085B8C File Offset: 0x00083D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541019, XrefRangeEnd = 541022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedRigging GetRig(string rigName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rigName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr_GetRig_Public_NamedRigging_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamedRigging>(intPtr3) : null;
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00085BDC File Offset: 0x00083DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541022, XrefRangeEnd = 541030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyGrip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyGrip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyGrip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0001062C File Offset: 0x0000E82C
		public KeyGrip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00085C18 File Offset: 0x00083E18
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00010635 File Offset: 0x0000E835
		public unsafe Dictionary<string, NamedRigging> namedRigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr_namedRigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NamedRigging>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr_namedRigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00085C48 File Offset: 0x00083E48
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00010654 File Offset: 0x0000E854
		public unsafe NamedRigging currentRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr_currentRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamedRigging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr_currentRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00085C78 File Offset: 0x00083E78
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00010673 File Offset: 0x0000E873
		public unsafe Camera _MainCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr__MainCamera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyGrip.NativeFieldInfoPtr__MainCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr_namedRigs;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeFieldInfoPtr_currentRig;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeFieldInfoPtr__MainCamera_k__BackingField;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_get_MainCamera_Public_get_Camera_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_set_MainCamera_Private_set_Void_Camera_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_String_NamedRigging_Boolean_Camera_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_String_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRig_Public_Void_String_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_GetRig_Public_NamedRigging_String_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
