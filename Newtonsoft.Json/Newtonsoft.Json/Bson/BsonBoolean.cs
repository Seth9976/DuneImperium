using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010A RID: 266
	public class BsonBoolean : BsonValue
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x00076458 File Offset: 0x00074658
		// Note: this type is marked as 'beforefieldinit'.
		static BsonBoolean()
		{
			Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonBoolean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr);
			BsonBoolean.NativeFieldInfoPtr_False = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr, "False");
			BsonBoolean.NativeFieldInfoPtr_True = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr, "True");
			BsonBoolean.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr, 100667414);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x000764C4 File Offset: 0x000746C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767126, XrefRangeEnd = 767131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonBoolean(bool value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonBoolean>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBoolean.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0000893C File Offset: 0x00006B3C
		public BsonBoolean(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0007650C File Offset: 0x0007470C
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00008945 File Offset: 0x00006B45
		public unsafe static BsonBoolean False
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonBoolean.NativeFieldInfoPtr_False, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonBoolean>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonBoolean.NativeFieldInfoPtr_False, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00076534 File Offset: 0x00074734
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x00008957 File Offset: 0x00006B57
		public unsafe static BsonBoolean True
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonBoolean.NativeFieldInfoPtr_True, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonBoolean>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonBoolean.NativeFieldInfoPtr_True, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr_False;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr_True;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;
	}
}
