using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000153 RID: 339
	[Serializable]
	public class DBGSequence : Object
	{
		// Token: 0x06000EE6 RID: 3814 RVA: 0x00058094 File Offset: 0x00056294
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSequence()
		{
			Il2CppClassPointerStore<DBGSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr);
			DBGSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr, "Name");
			DBGSequence.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr, "ID");
			DBGSequence.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr, "Attributes");
			DBGSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr, 100666525);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00058114 File Offset: 0x00056314
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000783D File Offset: 0x00005A3D
		public DBGSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00058150 File Offset: 0x00056350
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00007846 File Offset: 0x00005A46
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00058178 File Offset: 0x00056378
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00007865 File Offset: 0x00005A65
		public unsafe SequenceID ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_ID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_ID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000581A8 File Offset: 0x000563A8
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00007884 File Offset: 0x00005A84
		public unsafe MutableAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSequence.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
