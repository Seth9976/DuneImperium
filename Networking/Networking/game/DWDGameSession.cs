using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.game
{
	// Token: 0x020000AB RID: 171
	public class DWDGameSession : Object
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00014B44 File Offset: 0x00012D44
		// Note: this type is marked as 'beforefieldinit'.
		static DWDGameSession()
		{
			Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game", "DWDGameSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr);
			DWDGameSession.NativeFieldInfoPtr_GameProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "GameProperties");
			DWDGameSession.NativeFieldInfoPtr_CreatorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "CreatorID");
			DWDGameSession.NativeFieldInfoPtr_GameSessionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "GameSessionData");
			DWDGameSession.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "GameSessionID");
			DWDGameSession.NativeFieldInfoPtr_MaximumPlayerSessionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "MaximumPlayerSessionCount");
			DWDGameSession.NativeFieldInfoPtr_CurrentPlayerSessionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "CurrentPlayerSessionCount");
			DWDGameSession.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "Name");
			DWDGameSession.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "Port");
			DWDGameSession.NativeFieldInfoPtr_IPAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "IPAddress");
			DWDGameSession.NativeFieldInfoPtr_DnsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, "DnsName");
			DWDGameSession.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, 100663647);
			DWDGameSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr, 100663648);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00014C64 File Offset: 0x00012E64
		public unsafe GameID GameID
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1195209, RefRangeEnd = 1195218, XrefRangeStart = 1195204, XrefRangeEnd = 1195209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDGameSession.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00014CA4 File Offset: 0x00012EA4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDGameSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDGameSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDGameSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005673 File Offset: 0x00003873
		public DWDGameSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00014CE0 File Offset: 0x00012EE0
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000567C File Offset: 0x0000387C
		public unsafe List<DWDGameProperty> GameProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DWDGameProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00014D10 File Offset: 0x00012F10
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000569B File Offset: 0x0000389B
		public unsafe AccountID CreatorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_CreatorID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_CreatorID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00014D40 File Offset: 0x00012F40
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000056BA File Offset: 0x000038BA
		public unsafe string GameSessionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameSessionData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameSessionData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00014D68 File Offset: 0x00012F68
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000056D9 File Offset: 0x000038D9
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00014D90 File Offset: 0x00012F90
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000056F8 File Offset: 0x000038F8
		public unsafe int MaximumPlayerSessionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_MaximumPlayerSessionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_MaximumPlayerSessionCount)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00014DB8 File Offset: 0x00012FB8
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00005713 File Offset: 0x00003913
		public unsafe int CurrentPlayerSessionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_CurrentPlayerSessionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_CurrentPlayerSessionCount)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00014DE0 File Offset: 0x00012FE0
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000572E File Offset: 0x0000392E
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00014E08 File Offset: 0x00013008
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000574D File Offset: 0x0000394D
		public unsafe int Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_Port)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00014E30 File Offset: 0x00013030
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00005768 File Offset: 0x00003968
		public unsafe string IPAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_IPAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_IPAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00014E58 File Offset: 0x00013058
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00005787 File Offset: 0x00003987
		public unsafe string DnsName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_DnsName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDGameSession.NativeFieldInfoPtr_DnsName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_GameProperties;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_CreatorID;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionData;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_MaximumPlayerSessionCount;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPlayerSessionCount;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_IPAddress;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_DnsName;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
