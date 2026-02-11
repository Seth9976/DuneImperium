using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A8 RID: 168
	[Serializable]
	public class Encapsulator : Object
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x000296D8 File Offset: 0x000278D8
		// Note: this type is marked as 'beforefieldinit'.
		static Encapsulator()
		{
			Il2CppClassPointerStore<Encapsulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "Encapsulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr);
			Encapsulator.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, "m_Start");
			Encapsulator.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, "m_End");
			Encapsulator.NativeMethodInfoPtr_get_Start_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664780);
			Encapsulator.NativeMethodInfoPtr_set_Start_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664781);
			Encapsulator.NativeMethodInfoPtr_get_End_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664782);
			Encapsulator.NativeMethodInfoPtr_set_End_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664783);
			Encapsulator.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664784);
			Encapsulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr, 100664785);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000297A8 File Offset: 0x000279A8
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x000297E0 File Offset: 0x000279E0
		public unsafe string Start
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr_get_Start_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr_set_Start_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00029824 File Offset: 0x00027A24
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x0002985C File Offset: 0x00027A5C
		public unsafe string End
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr_get_End_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr_set_End_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000298A0 File Offset: 0x00027AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076571, XrefRangeEnd = 1076582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000298E4 File Offset: 0x00027AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076582, XrefRangeEnd = 1076591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encapsulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encapsulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encapsulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00005313 File Offset: 0x00003513
		public Encapsulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00029920 File Offset: 0x00027B20
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0000531C File Offset: 0x0000351C
		public unsafe string m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encapsulator.NativeFieldInfoPtr_m_Start);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encapsulator.NativeFieldInfoPtr_m_Start), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00029948 File Offset: 0x00027B48
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0000533B File Offset: 0x0000353B
		public unsafe string m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encapsulator.NativeFieldInfoPtr_m_End);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encapsulator.NativeFieldInfoPtr_m_End), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_get_String_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_set_Start_Public_set_Void_String_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_End_Public_get_String_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_set_End_Public_set_Void_String_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
