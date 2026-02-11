using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.data.matchinitdata
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	public class ClientMatchConfigData : Object
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x00058DB4 File Offset: 0x00056FB4
		// Note: this type is marked as 'beforefieldinit'.
		static ClientMatchConfigData()
		{
			Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data.matchinitdata", "ClientMatchConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr);
			ClientMatchConfigData.NativeFieldInfoPtr_MinPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "MinPlayers");
			ClientMatchConfigData.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "MaxPlayers");
			ClientMatchConfigData.NativeFieldInfoPtr_MinHumanPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "MinHumanPlayers");
			ClientMatchConfigData.NativeFieldInfoPtr_MaxHumanPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "MaxHumanPlayers");
			ClientMatchConfigData.NativeFieldInfoPtr_DefaultPlayerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "DefaultPlayerNames");
			ClientMatchConfigData.NativeFieldInfoPtr_PrerequisiteScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "PrerequisiteScenarios");
			ClientMatchConfigData.NativeFieldInfoPtr_ScenarioImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "ScenarioImage");
			ClientMatchConfigData.NativeFieldInfoPtr_NextScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "NextScenario");
			ClientMatchConfigData.NativeFieldInfoPtr_AllowSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, "AllowSave");
			ClientMatchConfigData.NativeMethodInfoPtr_Clone_Public_Static_ClientMatchConfigData_ClientMatchConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, 100666533);
			ClientMatchConfigData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr, 100666534);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00058EC0 File Offset: 0x000570C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 578001, RefRangeEnd = 578002, XrefRangeStart = 577971, XrefRangeEnd = 578001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientMatchConfigData Clone(ClientMatchConfigData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientMatchConfigData.NativeMethodInfoPtr_Clone_Public_Static_ClientMatchConfigData_ClientMatchConfigData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientMatchConfigData>(intPtr3) : null;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00058F04 File Offset: 0x00057104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578002, XrefRangeEnd = 578015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientMatchConfigData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientMatchConfigData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientMatchConfigData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00007C34 File Offset: 0x00005E34
		public ClientMatchConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00058F40 File Offset: 0x00057140
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00007C3D File Offset: 0x00005E3D
		public unsafe int MinPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MinPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MinPlayers)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00058F68 File Offset: 0x00057168
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00007C58 File Offset: 0x00005E58
		public unsafe int MaxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MaxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MaxPlayers)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00058F90 File Offset: 0x00057190
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00007C73 File Offset: 0x00005E73
		public unsafe int MinHumanPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MinHumanPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MinHumanPlayers)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00058FB8 File Offset: 0x000571B8
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00007C8E File Offset: 0x00005E8E
		public unsafe int MaxHumanPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MaxHumanPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_MaxHumanPlayers)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00058FE0 File Offset: 0x000571E0
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public unsafe List<string> DefaultPlayerNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_DefaultPlayerNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_DefaultPlayerNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00059010 File Offset: 0x00057210
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public unsafe List<string> PrerequisiteScenarios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_PrerequisiteScenarios);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_PrerequisiteScenarios), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00059040 File Offset: 0x00057240
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00007CE7 File Offset: 0x00005EE7
		public unsafe string ScenarioImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_ScenarioImage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_ScenarioImage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00059068 File Offset: 0x00057268
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00007D06 File Offset: 0x00005F06
		public unsafe string NextScenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_NextScenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_NextScenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00059090 File Offset: 0x00057290
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00007D25 File Offset: 0x00005F25
		public unsafe bool AllowSave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_AllowSave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientMatchConfigData.NativeFieldInfoPtr_AllowSave)) = value;
			}
		}

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_MinPlayers;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_MaxPlayers;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_MinHumanPlayers;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_MaxHumanPlayers;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPlayerNames;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteScenarios;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_ScenarioImage;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_NextScenario;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_AllowSave;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_ClientMatchConfigData_ClientMatchConfigData_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
