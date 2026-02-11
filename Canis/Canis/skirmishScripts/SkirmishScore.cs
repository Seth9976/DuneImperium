using System;
using System.Runtime.InteropServices;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x02000050 RID: 80
	public class SkirmishScore : Object
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x0002C5B4 File Offset: 0x0002A7B4
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScore()
		{
			Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishScore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr);
			SkirmishScore.NativeFieldInfoPtr_SkirmishTotalPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr, "SkirmishTotalPrompt");
			SkirmishScore.NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_Match_PlayerEntity_Il2CppReferenceArray_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr, 100664293);
			SkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr, 100664294);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002C620 File Offset: 0x0002A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553794, XrefRangeEnd = 553822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SkirmishScoreItem> GetSkirmishScore(Match match, PlayerEntity player, [Optional] Il2CppReferenceArray<SkirmishScoringMethod> methods)
		{
			if (methods == null)
			{
				methods = new Il2CppReferenceArray<SkirmishScoringMethod>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScore.NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_Match_PlayerEntity_Il2CppReferenceArray_1_SkirmishScoringMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkirmishScoreItem>>(intPtr3) : null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0002C698 File Offset: 0x0002A898
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishScore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000428D File Offset: 0x0000248D
		public static List<SkirmishScoreItem> GetSkirmishScore(Match match, PlayerEntity player, params SkirmishScoringMethod[] methods)
		{
			return SkirmishScore.GetSkirmishScore(match, player, new Il2CppReferenceArray<SkirmishScoringMethod>(methods));
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000429C File Offset: 0x0000249C
		public SkirmishScore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x000042A5 File Offset: 0x000024A5
		public unsafe static string SkirmishTotalPrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishScore.NativeFieldInfoPtr_SkirmishTotalPrompt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishScore.NativeFieldInfoPtr_SkirmishTotalPrompt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishTotalPrompt;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_Match_PlayerEntity_Il2CppReferenceArray_1_SkirmishScoringMethod_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
