using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000198 RID: 408
	public sealed class StyleDataRef<T> : ValueType where T : new()
	{
		// Token: 0x060021BA RID: 8634 RVA: 0x00097F9C File Offset: 0x0009619C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleDataRef()
		{
			Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleDataRef`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr);
			StyleDataRef<T>.NativeFieldInfoPtr_m_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, "m_Ref");
			StyleDataRef<T>.NativeMethodInfoPtr_Acquire_Public_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668269);
			StyleDataRef<T>.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668270);
			StyleDataRef<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668271);
			StyleDataRef<T>.NativeMethodInfoPtr_Read_Public_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668272);
			StyleDataRef<T>.NativeMethodInfoPtr_Write_Public_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668273);
			StyleDataRef<T>.NativeMethodInfoPtr_Create_Public_Static_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668274);
			StyleDataRef<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668275);
			StyleDataRef<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleDataRef_1_T_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668276);
			StyleDataRef<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668277);
			StyleDataRef<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668278);
			StyleDataRef<T>.NativeMethodInfoPtr_ReferenceEquals_Public_Boolean_StyleDataRef_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, 100668279);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000980F8 File Offset: 0x000962F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 334698, RefRangeEnd = 334710, XrefRangeStart = 334696, XrefRangeEnd = 334698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleDataRef<T> Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Acquire_Public_StyleDataRef_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StyleDataRef<T>(intPtr);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00098134 File Offset: 0x00096334
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334724, RefRangeEnd = 334730, XrefRangeStart = 334710, XrefRangeEnd = 334724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0009816C File Offset: 0x0009636C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334736, RefRangeEnd = 334737, XrefRangeStart = 334730, XrefRangeEnd = 334736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(StyleDataRef<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_StyleDataRef_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000981B8 File Offset: 0x000963B8
		[CallerCount(595)]
		[CachedScanResults(RefRangeStart = 334737, RefRangeEnd = 335332, XrefRangeStart = 334737, XrefRangeEnd = 334737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref T Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Read_Public_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000981F0 File Offset: 0x000963F0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 335338, RefRangeEnd = 335366, XrefRangeStart = 335332, XrefRangeEnd = 335338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref T Write()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Write_Public_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00098228 File Offset: 0x00096428
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335372, RefRangeEnd = 335378, XrefRangeStart = 335366, XrefRangeEnd = 335372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StyleDataRef<T> Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Create_Public_Static_StyleDataRef_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StyleDataRef<T>(intPtr);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00098254 File Offset: 0x00096454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335380, RefRangeEnd = 335381, XrefRangeStart = 335378, XrefRangeEnd = 335380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00098298 File Offset: 0x00096498
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleDataRef_1_T_StyleDataRef_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000982F8 File Offset: 0x000964F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335382, RefRangeEnd = 335383, XrefRangeStart = 335381, XrefRangeEnd = 335382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StyleDataRef<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleDataRef_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00098350 File Offset: 0x00096550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335383, XrefRangeEnd = 335390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000983A4 File Offset: 0x000965A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335390, RefRangeEnd = 335396, XrefRangeStart = 335390, XrefRangeEnd = 335390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReferenceEquals(StyleDataRef<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.NativeMethodInfoPtr_ReferenceEquals_Public_Boolean_StyleDataRef_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0000E193 File Offset: 0x0000C393
		public StyleDataRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0000E19C File Offset: 0x0000C39C
		public StyleDataRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x000983FC File Offset: 0x000965FC
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x0000E1AE File Offset: 0x0000C3AE
		public unsafe StyleDataRef<T>.RefCounted m_Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.NativeFieldInfoPtr_m_Ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleDataRef<T>.RefCounted>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.NativeFieldInfoPtr_m_Ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x0000E1CD File Offset: 0x0000C3CD
		public int refCount
		{
			get
			{
				StyleDataRef<T>.RefCounted @ref = this.m_Ref;
				return (@ref != null) ? @ref.refCount : 0;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x0000E1E1 File Offset: 0x0000C3E1
		public uint id
		{
			get
			{
				StyleDataRef<T>.RefCounted @ref = this.m_Ref;
				return (@ref != null) ? @ref.id : 0U;
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0009842C File Offset: 0x0009662C
		public static bool operator !=(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeFieldInfoPtr_m_Ref;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_StyleDataRef_1_T_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_StyleDataRef_1_T_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_byref_T_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_byref_T_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_StyleDataRef_1_T_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleDataRef_1_T_StyleDataRef_1_T_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleDataRef_1_T_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceEquals_Public_Boolean_StyleDataRef_1_T_0;

		// Token: 0x020004BE RID: 1214
		public class RefCounted : Object
		{
			// Token: 0x06003DFE RID: 15870 RVA: 0x000F7160 File Offset: 0x000F5360
			// Note: this type is marked as 'beforefieldinit'.
			static RefCounted()
			{
				Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleDataRef<T>>.NativeClassPtr, "RefCounted"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr);
				StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_NextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, "m_NextId");
				StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_RefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, "m_RefCount");
				StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, "m_Id");
				StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, "value");
				StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, 100668280);
				StyleDataRef<T>.RefCounted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, 100668281);
				StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Acquire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, 100668282);
				StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, 100668283);
				StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Copy_Public_RefCounted_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr, 100668284);
			}

			// Token: 0x170012C7 RID: 4807
			// (get) Token: 0x06003DFF RID: 15871 RVA: 0x000F727C File Offset: 0x000F547C
			public unsafe int refCount
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003E00 RID: 15872 RVA: 0x000F72B8 File Offset: 0x000F54B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334679, RefRangeEnd = 334680, XrefRangeStart = 334674, XrefRangeEnd = 334679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RefCounted()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleDataRef<T>.RefCounted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.RefCounted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E01 RID: 15873 RVA: 0x000F72F4 File Offset: 0x000F54F4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334682, XrefRangeStart = 334680, XrefRangeEnd = 334680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Acquire()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Acquire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E02 RID: 15874 RVA: 0x000F7328 File Offset: 0x000F5528
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 334682, RefRangeEnd = 334686, XrefRangeStart = 334682, XrefRangeEnd = 334682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E03 RID: 15875 RVA: 0x000F735C File Offset: 0x000F555C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334695, RefRangeEnd = 334696, XrefRangeStart = 334686, XrefRangeEnd = 334695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StyleDataRef<T>.RefCounted Copy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleDataRef<T>.RefCounted.NativeMethodInfoPtr_Copy_Public_RefCounted_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleDataRef<T>.RefCounted>(intPtr3) : null;
			}

			// Token: 0x06003E04 RID: 15876 RVA: 0x0001A1CB File Offset: 0x000183CB
			public RefCounted(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012C3 RID: 4803
			// (get) Token: 0x06003E05 RID: 15877 RVA: 0x000F739C File Offset: 0x000F559C
			// (set) Token: 0x06003E06 RID: 15878 RVA: 0x0001A1D4 File Offset: 0x000183D4
			public unsafe static uint m_NextId
			{
				get
				{
					uint num;
					IL2CPP.il2cpp_field_static_get_value(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_NextId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_NextId, (void*)(&value));
				}
			}

			// Token: 0x170012C4 RID: 4804
			// (get) Token: 0x06003E07 RID: 15879 RVA: 0x000F73B8 File Offset: 0x000F55B8
			// (set) Token: 0x06003E08 RID: 15880 RVA: 0x0001A1E2 File Offset: 0x000183E2
			public unsafe int m_RefCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_RefCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_RefCount)) = value;
				}
			}

			// Token: 0x170012C5 RID: 4805
			// (get) Token: 0x06003E09 RID: 15881 RVA: 0x000F73E0 File Offset: 0x000F55E0
			// (set) Token: 0x06003E0A RID: 15882 RVA: 0x0001A1FD File Offset: 0x000183FD
			public unsafe uint m_Id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_Id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_m_Id)) = value;
				}
			}

			// Token: 0x170012C6 RID: 4806
			// (get) Token: 0x06003E0B RID: 15883 RVA: 0x000F7408 File Offset: 0x000F5608
			// (set) Token: 0x06003E0C RID: 15884 RVA: 0x000F7430 File Offset: 0x000F5630
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleDataRef<T>.RefCounted.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04002BD0 RID: 11216
			private static readonly IntPtr NativeFieldInfoPtr_m_NextId;

			// Token: 0x04002BD1 RID: 11217
			private static readonly IntPtr NativeFieldInfoPtr_m_RefCount;

			// Token: 0x04002BD2 RID: 11218
			private static readonly IntPtr NativeFieldInfoPtr_m_Id;

			// Token: 0x04002BD3 RID: 11219
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002BD4 RID: 11220
			private static readonly IntPtr NativeMethodInfoPtr_get_refCount_Public_get_Int32_0;

			// Token: 0x04002BD5 RID: 11221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BD6 RID: 11222
			private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Void_0;

			// Token: 0x04002BD7 RID: 11223
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x04002BD8 RID: 11224
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_RefCounted_T_0;
		}
	}
}
