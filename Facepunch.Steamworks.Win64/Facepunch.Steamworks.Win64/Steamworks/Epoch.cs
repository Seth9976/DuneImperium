using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C2 RID: 194
	public static class Epoch : Object
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x00053134 File Offset: 0x00051334
		// Note: this type is marked as 'beforefieldinit'.
		static Epoch()
		{
			Il2CppClassPointerStore<Epoch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Epoch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Epoch>.NativeClassPtr);
			Epoch.NativeFieldInfoPtr_epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epoch>.NativeClassPtr, "epoch");
			Epoch.NativeMethodInfoPtr_get_Current_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epoch>.NativeClassPtr, 100666383);
			Epoch.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epoch>.NativeClassPtr, 100666384);
			Epoch.NativeMethodInfoPtr_FromDateTime_Public_Static_UInt32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epoch>.NativeClassPtr, 100666385);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000531B4 File Offset: 0x000513B4
		public unsafe static int Current
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 947282, RefRangeEnd = 947284, XrefRangeStart = 947269, XrefRangeEnd = 947282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Epoch.NativeMethodInfoPtr_get_Current_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000531E4 File Offset: 0x000513E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 947296, RefRangeEnd = 947303, XrefRangeStart = 947284, XrefRangeEnd = 947296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(Decimal unixTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unixTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Epoch.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00053224 File Offset: 0x00051424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947303, XrefRangeEnd = 947315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint FromDateTime(DateTime dt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Epoch.NativeMethodInfoPtr_FromDateTime_Public_Static_UInt32_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000031BE File Offset: 0x000013BE
		public Epoch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00053264 File Offset: 0x00051464
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x000031C7 File Offset: 0x000013C7
		public unsafe static DateTime epoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(Epoch.NativeFieldInfoPtr_epoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Epoch.NativeFieldInfoPtr_epoch, (void*)(&value));
			}
		}

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_epoch;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_Int32_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Decimal_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_FromDateTime_Public_Static_UInt32_DateTime_0;
	}
}
