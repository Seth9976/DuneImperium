using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000107 RID: 263
	public class BsonArray : BsonToken
	{
		// Token: 0x060015C7 RID: 5575 RVA: 0x00075ECC File Offset: 0x000740CC
		// Note: this type is marked as 'beforefieldinit'.
		static BsonArray()
		{
			Il2CppClassPointerStore<BsonArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonArray>.NativeClassPtr);
			BsonArray.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, "_children");
			BsonArray.NativeMethodInfoPtr_Add_Public_Void_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, 100667403);
			BsonArray.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, 100667404);
			BsonArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, 100667405);
			BsonArray.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, 100667406);
			BsonArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonArray>.NativeClassPtr, 100667407);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00075F74 File Offset: 0x00074174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767099, XrefRangeEnd = 767107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(BsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonArray.NativeMethodInfoPtr_Add_Public_Void_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00075FB8 File Offset: 0x000741B8
		public unsafe override BsonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonArray.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00076000 File Offset: 0x00074200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767113, RefRangeEnd = 767114, XrefRangeStart = 767107, XrefRangeEnd = 767113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<BsonToken> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<BsonToken>>(intPtr3) : null;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00076040 File Offset: 0x00074240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767114, XrefRangeEnd = 767115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonArray.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00076080 File Offset: 0x00074280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767115, XrefRangeEnd = 767123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00008889 File Offset: 0x00006A89
		public BsonArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000760BC File Offset: 0x000742BC
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x00008892 File Offset: 0x00006A92
		public unsafe List<BsonToken> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonArray.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BsonToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonArray.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_BsonToken_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonToken_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
