using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000320 RID: 800
	[Serializable]
	public sealed class MemberHolder : Object
	{
		// Token: 0x060030D4 RID: 12500 RVA: 0x000F8A8C File Offset: 0x000F6C8C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberHolder()
		{
			Il2CppClassPointerStore<MemberHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "MemberHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr);
			MemberHolder.NativeFieldInfoPtr__memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, "_memberType");
			MemberHolder.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, "_context");
			MemberHolder.NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100670986);
			MemberHolder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100670987);
			MemberHolder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr, 100670988);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000F8B20 File Offset: 0x000F6D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384628, RefRangeEnd = 1384629, XrefRangeStart = 1384625, XrefRangeEnd = 1384628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberHolder(Type type, StreamingContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberHolder.NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000F8B84 File Offset: 0x000F6D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberHolder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000F8BC0 File Offset: 0x000F6DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384629, XrefRangeEnd = 1384631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberHolder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x00010CC6 File Offset: 0x0000EEC6
		public MemberHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000F8C10 File Offset: 0x000F6E10
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x00010CCF File Offset: 0x0000EECF
		public unsafe Type _memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr__memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr__memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000F8C40 File Offset: 0x000F6E40
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x00010CEE File Offset: 0x0000EEEE
		public StreamingContext _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr__context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberHolder.NativeFieldInfoPtr__context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeFieldInfoPtr__memberType;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_StreamingContext_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
