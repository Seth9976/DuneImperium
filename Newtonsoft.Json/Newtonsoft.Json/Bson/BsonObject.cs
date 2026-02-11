using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000106 RID: 262
	public class BsonObject : BsonToken
	{
		// Token: 0x060015BE RID: 5566 RVA: 0x00075C9C File Offset: 0x00073E9C
		// Note: this type is marked as 'beforefieldinit'.
		static BsonObject()
		{
			Il2CppClassPointerStore<BsonObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonObject>.NativeClassPtr);
			BsonObject.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, "_children");
			BsonObject.NativeMethodInfoPtr_Add_Public_Void_String_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, 100667398);
			BsonObject.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, 100667399);
			BsonObject.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, 100667400);
			BsonObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, 100667401);
			BsonObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObject>.NativeClassPtr, 100667402);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00075D44 File Offset: 0x00073F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767064, XrefRangeEnd = 767083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string name, BsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObject.NativeMethodInfoPtr_Add_Public_Void_String_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00075D98 File Offset: 0x00073F98
		public unsafe override BsonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonObject.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00075DE0 File Offset: 0x00073FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767089, RefRangeEnd = 767090, XrefRangeStart = 767083, XrefRangeEnd = 767089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<BsonProperty> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObject.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<BsonProperty>>(intPtr3) : null;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00075E20 File Offset: 0x00074020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767090, XrefRangeEnd = 767091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00075E60 File Offset: 0x00074060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767091, XrefRangeEnd = 767099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00008861 File Offset: 0x00006A61
		public BsonObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00075E9C File Offset: 0x0007409C
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x0000886A File Offset: 0x00006A6A
		public unsafe List<BsonProperty> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonObject.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BsonProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonObject.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_BsonToken_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_BsonProperty_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
