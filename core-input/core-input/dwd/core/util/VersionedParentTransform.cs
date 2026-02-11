using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000037 RID: 55
	public class VersionedParentTransform : MonoBehaviour
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedParentTransform()
		{
			Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.util", "VersionedParentTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr);
			VersionedParentTransform.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, "<Version>k__BackingField");
			VersionedParentTransform.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, "<Initialized>k__BackingField");
			VersionedParentTransform.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, "parent");
			VersionedParentTransform.NativeFieldInfoPtr_propagateUpHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, "propagateUpHierarchy");
			VersionedParentTransform.NativeFieldInfoPtr_cachedTransformParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, "cachedTransformParent");
			VersionedParentTransform.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663515);
			VersionedParentTransform.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663516);
			VersionedParentTransform.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663517);
			VersionedParentTransform.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663518);
			VersionedParentTransform.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663519);
			VersionedParentTransform.NativeMethodInfoPtr_OnTransformChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663520);
			VersionedParentTransform.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663521);
			VersionedParentTransform.NativeMethodInfoPtr_ChildrenChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663522);
			VersionedParentTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr, 100663523);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000C320 File Offset: 0x0000A520
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000C35C File Offset: 0x0000A55C
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000C39C File Offset: 0x0000A59C
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000C418 File Offset: 0x0000A618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120168, XrefRangeEnd = 1120181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000C44C File Offset: 0x0000A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120181, XrefRangeEnd = 1120200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_OnTransformChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000C480 File Offset: 0x0000A680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120200, XrefRangeEnd = 1120201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedParentTransform.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1120206, RefRangeEnd = 1120209, XrefRangeStart = 1120201, XrefRangeEnd = 1120206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr_ChildrenChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 881793, RefRangeEnd = 881811, XrefRangeStart = 881793, XrefRangeEnd = 881811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedParentTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedParentTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedParentTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002F02 File Offset: 0x00001102
		public VersionedParentTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000C52C File Offset: 0x0000A72C
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002F0B File Offset: 0x0000110B
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002F26 File Offset: 0x00001126
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000C57C File Offset: 0x0000A77C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002F41 File Offset: 0x00001141
		public unsafe VersionedParentTransform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedParentTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002F60 File Offset: 0x00001160
		public unsafe bool propagateUpHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_propagateUpHierarchy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_propagateUpHierarchy)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002F7B File Offset: 0x0000117B
		public unsafe Transform cachedTransformParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_cachedTransformParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedParentTransform.NativeFieldInfoPtr_cachedTransformParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_propagateUpHierarchy;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransformParent;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ChildrenChanged_Public_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
