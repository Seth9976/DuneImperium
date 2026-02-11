using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace boardgames.attributes.providers
{
	// Token: 0x02000170 RID: 368
	public class MutableAttributesProvider : MonoBehaviour
	{
		// Token: 0x06001297 RID: 4759 RVA: 0x0004A43C File Offset: 0x0004863C
		// Note: this type is marked as 'beforefieldinit'.
		static MutableAttributesProvider()
		{
			Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "MutableAttributesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr);
			MutableAttributesProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, "attributes");
			MutableAttributesProvider.NativeFieldInfoPtr_mutableAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, "mutableAttributes");
			MutableAttributesProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666017);
			MutableAttributesProvider.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666018);
			MutableAttributesProvider.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666019);
			MutableAttributesProvider.NativeMethodInfoPtr_SetAttribute_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666020);
			MutableAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666021);
			MutableAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666022);
			MutableAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, 100666023);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0004A520 File Offset: 0x00048720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001040, XrefRangeEnd = 1001063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0004A554 File Offset: 0x00048754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001063, XrefRangeEnd = 1001069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolTrue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0004A594 File Offset: 0x00048794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001069, XrefRangeEnd = 1001075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBoolFalse(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0004A5D4 File Offset: 0x000487D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1001107, RefRangeEnd = 1001109, XrefRangeStart = 1001075, XrefRangeEnd = 1001107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute<T>(int index, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.MethodInfoStoreGeneric_SetAttribute_Public_Void_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0004A65C File Offset: 0x0004885C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0004A69C File Offset: 0x0004889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001109, XrefRangeEnd = 1001123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0004A6DC File Offset: 0x000488DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001123, XrefRangeEnd = 1001128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public MutableAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0004A718 File Offset: 0x00048918
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0000AAC1 File Offset: 0x00008CC1
		public unsafe Il2CppStructArray<int> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0004A748 File Offset: 0x00048948
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public unsafe MutableAttributes mutableAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesProvider.NativeFieldInfoPtr_mutableAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesProvider.NativeFieldInfoPtr_mutableAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_mutableAttributes;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolTrue_Public_Void_Int32_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBoolFalse_Public_Void_Int32_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_Int32_T_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028A RID: 650
		[ObfuscatedName("boardgames.attributes.providers.MutableAttributesProvider+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06001DFC RID: 7676 RVA: 0x000101DF File Offset: 0x0000E3DF
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<MutableAttributesProvider.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributesProvider.__O>.NativeClassPtr);
				MutableAttributesProvider.__O.NativeFieldInfoPtr__0___GetDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesProvider.__O>.NativeClassPtr, "<0>__GetDefinition");
			}

			// Token: 0x06001DFD RID: 7677 RVA: 0x00010213 File Offset: 0x0000E413
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
			// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0001021C File Offset: 0x0000E41C
			public unsafe static Func<int, IAttributeDefinition> _0___GetDefinition
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MutableAttributesProvider.__O.NativeFieldInfoPtr__0___GetDefinition, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IAttributeDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MutableAttributesProvider.__O.NativeFieldInfoPtr__0___GetDefinition, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123E RID: 4670
			private static readonly IntPtr NativeFieldInfoPtr__0___GetDefinition;
		}

		// Token: 0x0200028B RID: 651
		[ObfuscatedName("boardgames.attributes.providers.MutableAttributesProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001E00 RID: 7680 RVA: 0x0006D720 File Offset: 0x0006B920
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr);
				MutableAttributesProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr, "<>9");
				MutableAttributesProvider.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr, "<>9__2_0");
				MutableAttributesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr, 100666025);
				MutableAttributesProvider.__c.NativeMethodInfoPtr__Awake_b__2_0_Internal_IMutableAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr, 100666026);
			}

			// Token: 0x06001E01 RID: 7681 RVA: 0x0006D79C File Offset: 0x0006B99C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributesProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E02 RID: 7682 RVA: 0x0006D7D8 File Offset: 0x0006B9D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001032, XrefRangeEnd = 1001040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IMutableAttribute _Awake_b__2_0(int a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesProvider.__c.NativeMethodInfoPtr__Awake_b__2_0_Internal_IMutableAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMutableAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06001E03 RID: 7683 RVA: 0x0001022E File Offset: 0x0000E42E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0006D824 File Offset: 0x0006BA24
			// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00010237 File Offset: 0x0000E437
			public unsafe static MutableAttributesProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MutableAttributesProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributesProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MutableAttributesProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0006D84C File Offset: 0x0006BA4C
			// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00010249 File Offset: 0x0000E449
			public unsafe static Func<int, IMutableAttribute> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MutableAttributesProvider.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IMutableAttribute>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MutableAttributesProvider.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123F RID: 4671
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_0_Internal_IMutableAttribute_Int32_0;
		}

		// Token: 0x0200028C RID: 652
		private sealed class MethodInfoStoreGeneric_SetAttribute_Public_Void_Int32_T_0<T>
		{
			// Token: 0x04001243 RID: 4675
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributesProvider.NativeMethodInfoPtr_SetAttribute_Public_Void_Int32_T_0, Il2CppClassPointerStore<MutableAttributesProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
