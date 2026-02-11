using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002EC RID: 748
	public class CADObjRef : Object
	{
		// Token: 0x06002E60 RID: 11872 RVA: 0x000EFAC8 File Offset: 0x000EDCC8
		// Note: this type is marked as 'beforefieldinit'.
		static CADObjRef()
		{
			Il2CppClassPointerStore<CADObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr);
			CADObjRef.NativeFieldInfoPtr_objref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "objref");
			CADObjRef.NativeFieldInfoPtr_SourceDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "SourceDomain");
			CADObjRef.NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "TypeInfo");
			CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, 100670688);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000EFB48 File Offset: 0x000EDD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382512, XrefRangeEnd = 1382516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADObjRef(ObjRef o, int sourceDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		public CADObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x000EFBA4 File Offset: 0x000EDDA4
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x0000FBB1 File Offset: 0x0000DDB1
		public unsafe ObjRef objref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000EFBD4 File Offset: 0x000EDDD4
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		public unsafe int SourceDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain)) = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000EFBFC File Offset: 0x000EDDFC
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x0000FBEB File Offset: 0x0000DDEB
		public unsafe Il2CppStructArray<byte> TypeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr_objref;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr_SourceDomain;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeFieldInfoPtr_TypeInfo;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0;
	}
}
