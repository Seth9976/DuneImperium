using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B9 RID: 185
	public sealed class JEnumerable<T> : ValueType where T : JToken
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x0005DA58 File Offset: 0x0005BC58
		// Note: this type is marked as 'beforefieldinit'.
		static JEnumerable()
		{
			Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr);
			JEnumerable<T>.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, "Empty");
			JEnumerable<T>.NativeFieldInfoPtr__enumerable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, "_enumerable");
			JEnumerable<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666320);
			JEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666321);
			JEnumerable<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666322);
			JEnumerable<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666323);
			JEnumerable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666324);
			JEnumerable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666325);
			JEnumerable<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, 100666326);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005DB78 File Offset: 0x0005BD78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757885, RefRangeEnd = 757889, XrefRangeStart = 757881, XrefRangeEnd = 757885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JEnumerable(IEnumerable<T> enumerable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005DBC8 File Offset: 0x0005BDC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757899, RefRangeEnd = 757903, XrefRangeStart = 757889, XrefRangeEnd = 757899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0005DC0C File Offset: 0x0005BE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757903, XrefRangeEnd = 757923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000488 RID: 1160
		public unsafe IJEnumerable<JToken> this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757923, XrefRangeEnd = 757937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757937, XrefRangeEnd = 757938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(JEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0005DD00 File Offset: 0x0005BF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757938, XrefRangeEnd = 757948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0005DD54 File Offset: 0x0005BF54
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JEnumerable<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00007743 File Offset: 0x00005943
		public JEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000774C File Offset: 0x0000594C
		public JEnumerable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0005DD98 File Offset: 0x0005BF98
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0000775E File Offset: 0x0000595E
		public unsafe static JEnumerable<T> Empty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(JEnumerable<T>.NativeFieldInfoPtr_Empty, intPtr);
				return new JEnumerable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JEnumerable<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JEnumerable<T>.NativeFieldInfoPtr_Empty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0005DDD4 File Offset: 0x0005BFD4
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00007775 File Offset: 0x00005975
		public unsafe IEnumerable<T> _enumerable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JEnumerable<T>.NativeFieldInfoPtr__enumerable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JEnumerable<T>.NativeFieldInfoPtr__enumerable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeFieldInfoPtr__enumerable;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JEnumerable_1_T_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
