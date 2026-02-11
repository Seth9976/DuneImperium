using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x02000163 RID: 355
	public class DailyChallengeSeasonGameRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004FF64 File Offset: 0x0004E164
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeSeasonGameRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeSeasonGameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr);
			DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_seasonAndGameLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr, "seasonAndGameLocKey");
			DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSkirmishesLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr, "betweenSkirmishesLocKey");
			DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSeasonsLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr, "betweenSeasonsLocKey");
			DailyChallengeSeasonGameRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr, 100665554);
			DailyChallengeSeasonGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr, 100665555);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004FFF8 File Offset: 0x0004E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513687, XrefRangeEnd = 513706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeSeasonGameRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00050048 File Offset: 0x0004E248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513706, XrefRangeEnd = 513716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeSeasonGameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeSeasonGameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeSeasonGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00009AF5 File Offset: 0x00007CF5
		public DailyChallengeSeasonGameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00050084 File Offset: 0x0004E284
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00009AFE File Offset: 0x00007CFE
		public unsafe string seasonAndGameLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_seasonAndGameLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_seasonAndGameLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000500AC File Offset: 0x0004E2AC
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00009B1D File Offset: 0x00007D1D
		public unsafe string betweenSkirmishesLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSkirmishesLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSkirmishesLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000500D4 File Offset: 0x0004E2D4
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00009B3C File Offset: 0x00007D3C
		public unsafe string betweenSeasonsLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSeasonsLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSeasonGameRenderer.NativeFieldInfoPtr_betweenSeasonsLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_seasonAndGameLocKey;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_betweenSkirmishesLocKey;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_betweenSeasonsLocKey;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
