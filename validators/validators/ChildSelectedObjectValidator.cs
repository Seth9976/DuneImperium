using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace validators
{
	// Token: 0x0200000E RID: 14
	public class ChildSelectedObjectValidator : MonoBehaviour
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003740 File Offset: 0x00001940
		// Note: this type is marked as 'beforefieldinit'.
		static ChildSelectedObjectValidator()
		{
			Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "ChildSelectedObjectValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr);
			ChildSelectedObjectValidator.NativeFieldInfoPtr_childSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, "childSelectables");
			ChildSelectedObjectValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, "<Valid>k__BackingField");
			ChildSelectedObjectValidator.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, 100663326);
			ChildSelectedObjectValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, 100663327);
			ChildSelectedObjectValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, 100663328);
			ChildSelectedObjectValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, 100663329);
			ChildSelectedObjectValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000037FC File Offset: 0x000019FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267557, XrefRangeEnd = 1267583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003830 File Offset: 0x00001A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267583, XrefRangeEnd = 1267590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003864 File Offset: 0x00001A64
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000038A0 File Offset: 0x00001AA0
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000038E0 File Offset: 0x00001AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267590, XrefRangeEnd = 1267598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildSelectedObjectValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000229D File Offset: 0x0000049D
		public ChildSelectedObjectValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000391C File Offset: 0x00001B1C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000022A6 File Offset: 0x000004A6
		public unsafe List<GameObject> childSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildSelectedObjectValidator.NativeFieldInfoPtr_childSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildSelectedObjectValidator.NativeFieldInfoPtr_childSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000394C File Offset: 0x00001B4C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildSelectedObjectValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildSelectedObjectValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_childSelectables;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000020 RID: 32
		[ObfuscatedName("validators.ChildSelectedObjectValidator+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600010C RID: 268 RVA: 0x00005918 File Offset: 0x00003B18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChildSelectedObjectValidator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr);
				ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr, "<>9");
				ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr, "<>9__1_0");
				ChildSelectedObjectValidator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr, 100663332);
				ChildSelectedObjectValidator.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_GameObject_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr, 100663333);
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00005994 File Offset: 0x00003B94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildSelectedObjectValidator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600010E RID: 270 RVA: 0x000059D0 File Offset: 0x00003BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267548, XrefRangeEnd = 1267557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameObject _Start_b__1_0(Selectable child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildSelectedObjectValidator.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_GameObject_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
			}

			// Token: 0x0600010F RID: 271 RVA: 0x0000280E File Offset: 0x00000A0E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00005A20 File Offset: 0x00003C20
			// (set) Token: 0x06000111 RID: 273 RVA: 0x00002817 File Offset: 0x00000A17
			public unsafe static ChildSelectedObjectValidator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChildSelectedObjectValidator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00005A48 File Offset: 0x00003C48
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00002829 File Offset: 0x00000A29
			public unsafe static Func<Selectable, GameObject> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Selectable, GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChildSelectedObjectValidator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Internal_GameObject_Selectable_0;
		}
	}
}
