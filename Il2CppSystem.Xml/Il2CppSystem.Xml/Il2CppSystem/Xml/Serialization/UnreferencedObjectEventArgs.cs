using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BB RID: 187
	public class UnreferencedObjectEventArgs : EventArgs
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x00067ED4 File Offset: 0x000660D4
		// Note: this type is marked as 'beforefieldinit'.
		static UnreferencedObjectEventArgs()
		{
			Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "UnreferencedObjectEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr);
			UnreferencedObjectEventArgs.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, "o");
			UnreferencedObjectEventArgs.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, "id");
			UnreferencedObjectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, 100666349);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00067F40 File Offset: 0x00066140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383798, RefRangeEnd = 383799, XrefRangeStart = 383792, XrefRangeEnd = 383798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnreferencedObjectEventArgs(Object o, string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnreferencedObjectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00007E80 File Offset: 0x00006080
		public UnreferencedObjectEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00067FA0 File Offset: 0x000661A0
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00007E89 File Offset: 0x00006089
		public unsafe Object o
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnreferencedObjectEventArgs.NativeFieldInfoPtr_o);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnreferencedObjectEventArgs.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00067FD0 File Offset: 0x000661D0
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00007EA8 File Offset: 0x000060A8
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnreferencedObjectEventArgs.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnreferencedObjectEventArgs.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_o;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_0;
	}
}
