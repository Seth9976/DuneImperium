using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000114 RID: 276
	[Serializable]
	public class ObjectParameter<T> : VolumeParameter<T>
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x00051F64 File Offset: 0x00050164
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectParameter()
		{
			Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ObjectParameter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr);
			ObjectParameter<T>.NativeFieldInfoPtr__parameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, "<parameters>k__BackingField");
			ObjectParameter<T>.NativeMethodInfoPtr_get_parameters_Internal_get_ReadOnlyCollection_1_VolumeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665934);
			ObjectParameter<T>.NativeMethodInfoPtr_set_parameters_Private_set_Void_ReadOnlyCollection_1_VolumeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665935);
			ObjectParameter<T>.NativeMethodInfoPtr_get_overrideState_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665936);
			ObjectParameter<T>.NativeMethodInfoPtr_set_overrideState_Public_Virtual_Final_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665937);
			ObjectParameter<T>.NativeMethodInfoPtr_get_value_Public_Virtual_Final_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665938);
			ObjectParameter<T>.NativeMethodInfoPtr_set_value_Public_Virtual_Final_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665939);
			ObjectParameter<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665940);
			ObjectParameter<T>.NativeMethodInfoPtr_Interp_Internal_Virtual_Void_VolumeParameter_VolumeParameter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665941);
			ObjectParameter<T>.NativeMethodInfoPtr__set_value_b__9_2_Private_VolumeParameter_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, 100665942);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x00052098 File Offset: 0x00050298
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000520D8 File Offset: 0x000502D8
		public unsafe ReadOnlyCollection<VolumeParameter> parameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979188, XrefRangeEnd = 979189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_get_parameters_Internal_get_ReadOnlyCollection_1_VolumeParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<VolumeParameter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979189, XrefRangeEnd = 979192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_set_parameters_Private_set_Void_ReadOnlyCollection_1_VolumeParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0005211C File Offset: 0x0005031C
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x00052158 File Offset: 0x00050358
		public unsafe override bool overrideState
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_get_overrideState_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_set_overrideState_Public_Virtual_Final_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00052198 File Offset: 0x00050398
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x000521D4 File Offset: 0x000503D4
		public unsafe override T value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979192, XrefRangeEnd = 979196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_get_value_Public_Virtual_Final_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979196, XrefRangeEnd = 979254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr_set_value_Public_Virtual_Final_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0005224C File Offset: 0x0005044C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979254, XrefRangeEnd = 979256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectParameter(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000522D0 File Offset: 0x000504D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979256, XrefRangeEnd = 979282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectParameter<T>.NativeMethodInfoPtr_Interp_Internal_Virtual_Void_VolumeParameter_VolumeParameter_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00052340 File Offset: 0x00050540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979282, XrefRangeEnd = 979288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeParameter _set_value_b__9_2(FieldInfo t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.NativeMethodInfoPtr__set_value_b__9_2_Private_VolumeParameter_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeParameter>(intPtr3) : null;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000094FB File Offset: 0x000076FB
		public ObjectParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00052390 File Offset: 0x00050590
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x00009504 File Offset: 0x00007704
		public unsafe ReadOnlyCollection<VolumeParameter> _parameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectParameter<T>.NativeFieldInfoPtr__parameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<VolumeParameter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectParameter<T>.NativeFieldInfoPtr__parameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeFieldInfoPtr__parameters_k__BackingField;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_parameters_Internal_get_ReadOnlyCollection_1_VolumeParameter_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_set_parameters_Private_set_Void_ReadOnlyCollection_1_VolumeParameter_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideState_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideState_Public_Virtual_Final_set_Void_Boolean_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_get_T_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_Final_set_Void_T_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Internal_Virtual_Void_VolumeParameter_VolumeParameter_Single_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr__set_value_b__9_2_Private_VolumeParameter_FieldInfo_0;

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("UnityEngine.Rendering.ObjectParameter`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B16 RID: 6934 RVA: 0x0006ED44 File Offset: 0x0006CF44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectParameter<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr);
				ObjectParameter<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, "<>9");
				ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, "<>9__9_0");
				ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, "<>9__9_1");
				ObjectParameter<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, 100665944);
				ObjectParameter<T>.__c.NativeMethodInfoPtr__set_value_b__9_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, 100665945);
				ObjectParameter<T>.__c.NativeMethodInfoPtr__set_value_b__9_1_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr, 100665946);
			}

			// Token: 0x06001B17 RID: 6935 RVA: 0x0006EE24 File Offset: 0x0006D024
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectParameter<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B18 RID: 6936 RVA: 0x0006EE60 File Offset: 0x0006D060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979181, XrefRangeEnd = 979188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _set_value_b__9_0(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.__c.NativeMethodInfoPtr__set_value_b__9_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B19 RID: 6937 RVA: 0x0006EEB0 File Offset: 0x0006D0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _set_value_b__9_1(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectParameter<T>.__c.NativeMethodInfoPtr__set_value_b__9_1_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B1A RID: 6938 RVA: 0x0000D8E7 File Offset: 0x0000BAE7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0006EF00 File Offset: 0x0006D100
			// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			public unsafe static ObjectParameter<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectParameter<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0006EF28 File Offset: 0x0006D128
			// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000D902 File Offset: 0x0000BB02
			public unsafe static Func<FieldInfo, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0006EF50 File Offset: 0x0006D150
			// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000D914 File Offset: 0x0000BB14
			public unsafe static Func<FieldInfo, int> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectParameter<T>.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C1 RID: 5057
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeMethodInfoPtr__set_value_b__9_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeMethodInfoPtr__set_value_b__9_1_Internal_Int32_FieldInfo_0;
		}
	}
}
