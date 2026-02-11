using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x02000011 RID: 17
	public class SendDireByteTileAnalytics : Subscriber<DireByteTileBaseData>
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00005910 File Offset: 0x00003B10
		// Note: this type is marked as 'beforefieldinit'.
		static SendDireByteTileAnalytics()
		{
			Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "SendDireByteTileAnalytics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr);
			SendDireByteTileAnalytics.NativeFieldInfoPtr_displayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, "displayType");
			SendDireByteTileAnalytics.NativeFieldInfoPtr_tilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, "tilePosition");
			SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, "displayTypePrompt");
			SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypeLanding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, "displayTypeLanding");
			SendDireByteTileAnalytics.NativeFieldInfoPtr_direBytesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, "direBytesProvider");
			SendDireByteTileAnalytics.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663396);
			SendDireByteTileAnalytics.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663397);
			SendDireByteTileAnalytics.NativeMethodInfoPtr_Event_SendTileClickedAnalytics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663398);
			SendDireByteTileAnalytics.NativeMethodInfoPtr_sendTileShownAnalytics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663399);
			SendDireByteTileAnalytics.NativeMethodInfoPtr_initializeDireByteAnalyticInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663400);
			SendDireByteTileAnalytics.NativeMethodInfoPtr_getTilePosition_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663401);
			SendDireByteTileAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr, 100663402);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005A30 File Offset: 0x00003C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234776, XrefRangeEnd = 1234779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendDireByteTileAnalytics.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005A6C File Offset: 0x00003C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234779, XrefRangeEnd = 1234785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendDireByteTileAnalytics.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234785, XrefRangeEnd = 1234807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendTileClickedAnalytics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendDireByteTileAnalytics.NativeMethodInfoPtr_Event_SendTileClickedAnalytics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005ADC File Offset: 0x00003CDC
		[CallerCount(0)]
		public unsafe void sendTileShownAnalytics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendDireByteTileAnalytics.NativeMethodInfoPtr_sendTileShownAnalytics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005B10 File Offset: 0x00003D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234807, XrefRangeEnd = 1234809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializeDireByteAnalyticInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendDireByteTileAnalytics.NativeMethodInfoPtr_initializeDireByteAnalyticInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005B44 File Offset: 0x00003D44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234831, RefRangeEnd = 1234834, XrefRangeStart = 1234809, XrefRangeEnd = 1234831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getTilePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendDireByteTileAnalytics.NativeMethodInfoPtr_getTilePosition_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005B80 File Offset: 0x00003D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234834, XrefRangeEnd = 1234840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendDireByteTileAnalytics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendDireByteTileAnalytics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendDireByteTileAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000260F File Offset: 0x0000080F
		public SendDireByteTileAnalytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005BBC File Offset: 0x00003DBC
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002618 File Offset: 0x00000818
		public unsafe string displayType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00005BE4 File Offset: 0x00003DE4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002637 File Offset: 0x00000837
		public unsafe int tilePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_tilePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_tilePosition)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005C0C File Offset: 0x00003E0C
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002652 File Offset: 0x00000852
		public unsafe static string displayTypePrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypePrompt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypePrompt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005C2C File Offset: 0x00003E2C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002664 File Offset: 0x00000864
		public unsafe static string displayTypeLanding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypeLanding, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendDireByteTileAnalytics.NativeFieldInfoPtr_displayTypeLanding, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005C4C File Offset: 0x00003E4C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002676 File Offset: 0x00000876
		public unsafe DireBytesProvider direBytesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_direBytesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendDireByteTileAnalytics.NativeFieldInfoPtr_direBytesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_displayType;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_tilePosition;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_displayTypePrompt;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_displayTypeLanding;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_direBytesProvider;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendTileClickedAnalytics_Public_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_sendTileShownAnalytics_Private_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_initializeDireByteAnalyticInfo_Private_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_getTilePosition_Private_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
