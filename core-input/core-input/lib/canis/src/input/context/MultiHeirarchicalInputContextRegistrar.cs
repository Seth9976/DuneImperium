using System;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lib.canis.src.input.context
{
	// Token: 0x02000010 RID: 16
	public class MultiHeirarchicalInputContextRegistrar : MonoBehaviour
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00008668 File Offset: 0x00006868
		// Note: this type is marked as 'beforefieldinit'.
		static MultiHeirarchicalInputContextRegistrar()
		{
			Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.canis.src.input.context", "MultiHeirarchicalInputContextRegistrar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr);
			MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registrar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, "registrar");
			MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registeredTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, "registeredTransforms");
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RemoveInputContextFromRegister_Public_Void_String_CreateMultiHeirarchyInputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663348);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RegisterInputContext_Public_Void_String_CreateMultiHeirarchyInputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663349);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RegisterTransformWithInputContextByID_Public_Void_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663350);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_DeregisterTransformWithInputContextByID_Public_Void_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663351);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_GetInputContextByID_Public_CreateMultiHeirarchyInputContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663352);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_getTransformListForID_Private_HashSet_1_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663353);
			MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000874C File Offset: 0x0000694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119136, XrefRangeEnd = 1119146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInputContextFromRegister(string id, CreateMultiHeirarchyInputContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RemoveInputContextFromRegister_Public_Void_String_CreateMultiHeirarchyInputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000087A0 File Offset: 0x000069A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1119174, RefRangeEnd = 1119175, XrefRangeStart = 1119146, XrefRangeEnd = 1119174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInputContext(string id, CreateMultiHeirarchyInputContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RegisterInputContext_Public_Void_String_CreateMultiHeirarchyInputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000087F4 File Offset: 0x000069F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119175, XrefRangeEnd = 1119183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTransformWithInputContextByID(string id, Transform tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_RegisterTransformWithInputContextByID_Public_Void_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008848 File Offset: 0x00006A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119183, XrefRangeEnd = 1119196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTransformWithInputContextByID(string id, Transform tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_DeregisterTransformWithInputContextByID_Public_Void_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000889C File Offset: 0x00006A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119196, XrefRangeEnd = 1119199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateMultiHeirarchyInputContext GetInputContextByID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_GetInputContextByID_Public_CreateMultiHeirarchyInputContext_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CreateMultiHeirarchyInputContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000088EC File Offset: 0x00006AEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1119229, RefRangeEnd = 1119234, XrefRangeStart = 1119199, XrefRangeEnd = 1119229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<Transform> getTransformListForID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr_getTransformListForID_Private_HashSet_1_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000893C File Offset: 0x00006B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119234, XrefRangeEnd = 1119249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiHeirarchicalInputContextRegistrar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000227E File Offset: 0x0000047E
		public MultiHeirarchicalInputContextRegistrar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00008978 File Offset: 0x00006B78
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002287 File Offset: 0x00000487
		public unsafe Dictionary<string, CreateMultiHeirarchyInputContext> registrar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registrar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CreateMultiHeirarchyInputContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registrar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000089A8 File Offset: 0x00006BA8
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000022A6 File Offset: 0x000004A6
		public unsafe Dictionary<string, HashSet<Transform>> registeredTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registeredTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Transform>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiHeirarchicalInputContextRegistrar.NativeFieldInfoPtr_registeredTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_registrar;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_registeredTransforms;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInputContextFromRegister_Public_Void_String_CreateMultiHeirarchyInputContext_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInputContext_Public_Void_String_CreateMultiHeirarchyInputContext_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTransformWithInputContextByID_Public_Void_String_Transform_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTransformWithInputContextByID_Public_Void_String_Transform_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetInputContextByID_Public_CreateMultiHeirarchyInputContext_String_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_getTransformListForID_Private_HashSet_1_Transform_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B5 RID: 181
		[ObfuscatedName("lib.canis.src.input.context.MultiHeirarchicalInputContextRegistrar+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000810 RID: 2064 RVA: 0x000212F8 File Offset: 0x0001F4F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr);
				MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr, "<>9");
				MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr, "<>9__7_0");
				MultiHeirarchicalInputContextRegistrar.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr, 100663356);
				MultiHeirarchicalInputContextRegistrar.__c.NativeMethodInfoPtr__getTransformListForID_b__7_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr, 100663357);
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x00021374 File Offset: 0x0001F574
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiHeirarchicalInputContextRegistrar.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x000213B0 File Offset: 0x0001F5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119132, XrefRangeEnd = 1119136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getTransformListForID_b__7_0(Transform tr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiHeirarchicalInputContextRegistrar.__c.NativeMethodInfoPtr__getTransformListForID_b__7_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x000063C9 File Offset: 0x000045C9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000814 RID: 2068 RVA: 0x00021400 File Offset: 0x0001F600
			// (set) Token: 0x06000815 RID: 2069 RVA: 0x000063D2 File Offset: 0x000045D2
			public unsafe static MultiHeirarchicalInputContextRegistrar.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiHeirarchicalInputContextRegistrar.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06000816 RID: 2070 RVA: 0x00021428 File Offset: 0x0001F628
			// (set) Token: 0x06000817 RID: 2071 RVA: 0x000063E4 File Offset: 0x000045E4
			public unsafe static Predicate<Transform> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultiHeirarchicalInputContextRegistrar.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004F8 RID: 1272
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004F9 RID: 1273
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040004FA RID: 1274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004FB RID: 1275
			private static readonly IntPtr NativeMethodInfoPtr__getTransformListForID_b__7_0_Internal_Boolean_Transform_0;
		}
	}
}
