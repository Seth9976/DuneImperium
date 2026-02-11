using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000074 RID: 116
	public class SetObjectActiveController : MonoBehaviour
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00023CF8 File Offset: 0x00021EF8
		// Note: this type is marked as 'beforefieldinit'.
		static SetObjectActiveController()
		{
			Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "SetObjectActiveController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr);
			SetObjectActiveController.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr, "table");
			SetObjectActiveController.NativeMethodInfoPtr_Register_Public_Void_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr, 100664259);
			SetObjectActiveController.NativeMethodInfoPtr_EnableObject_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr, 100664260);
			SetObjectActiveController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr, 100664261);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00023D78 File Offset: 0x00021F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988404, XrefRangeEnd = 988408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(string key, GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveController.NativeMethodInfoPtr_Register_Public_Void_String_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00023DCC File Offset: 0x00021FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 988423, RefRangeEnd = 988424, XrefRangeStart = 988408, XrefRangeEnd = 988423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableObject(string key, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveController.NativeMethodInfoPtr_EnableObject_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00023E1C File Offset: 0x0002201C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988424, XrefRangeEnd = 988432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetObjectActiveController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjectActiveController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00004C77 File Offset: 0x00002E77
		public SetObjectActiveController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00023E58 File Offset: 0x00022058
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00004C80 File Offset: 0x00002E80
		public unsafe Dictionary<string, GameObject> table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveController.NativeFieldInfoPtr_table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveController.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_String_GameObject_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_EnableObject_Public_Void_String_Boolean_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
