using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace Canis.entities.ai
{
	// Token: 0x020000FA RID: 250
	public class AIChoiceContext : Object
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x00048744 File Offset: 0x00046944
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoiceContext()
		{
			Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoiceContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr);
			AIChoiceContext.NativeFieldInfoPtr_offlineContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, "offlineContext");
			AIChoiceContext.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, "match");
			AIChoiceContext.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, "selection");
			AIChoiceContext.NativeFieldInfoPtr_intents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, "intents");
			AIChoiceContext.NativeFieldInfoPtr_rankedIntents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, "rankedIntents");
			AIChoiceContext.NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665701);
			AIChoiceContext.NativeMethodInfoPtr_IntentFor_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665702);
			AIChoiceContext.NativeMethodInfoPtr_RankedIntentFor_Public_IntentFitness_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665703);
			AIChoiceContext.NativeMethodInfoPtr_fitnessFor_Protected_IntentFitness_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665704);
			AIChoiceContext.NativeMethodInfoPtr_IncrementFitnessFor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665705);
			AIChoiceContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665706);
			AIChoiceContext.NativeMethodInfoPtr_SelectionToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr, 100665707);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00048864 File Offset: 0x00046A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 568274, RefRangeEnd = 568275, XrefRangeStart = 568257, XrefRangeEnd = 568274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoiceContext(Match m, SelectionMessage s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000488C4 File Offset: 0x00046AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568275, XrefRangeEnd = 568276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IntentFor(string intent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(intent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr_IntentFor_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00048914 File Offset: 0x00046B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568276, XrefRangeEnd = 568287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntentFitness RankedIntentFor(string intent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(intent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr_RankedIntentFor_Public_IntentFitness_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntentFitness>(intPtr3) : null;
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00048964 File Offset: 0x00046B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 568298, RefRangeEnd = 568300, XrefRangeStart = 568287, XrefRangeEnd = 568298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntentFitness fitnessFor(string intent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(intent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr_fitnessFor_Protected_IntentFitness_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntentFitness>(intPtr3) : null;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000489B4 File Offset: 0x00046BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568300, XrefRangeEnd = 568301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementFitnessFor(string intent, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(intent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr_IncrementFitnessFor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00048A04 File Offset: 0x00046C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568301, XrefRangeEnd = 568332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00048A48 File Offset: 0x00046C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568332, XrefRangeEnd = 568335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SelectionToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceContext.NativeMethodInfoPtr_SelectionToString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0000603B File Offset: 0x0000423B
		public AIChoiceContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00048A80 File Offset: 0x00046C80
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00006044 File Offset: 0x00004244
		public unsafe Context offlineContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_offlineContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_offlineContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00048AB0 File Offset: 0x00046CB0
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00006063 File Offset: 0x00004263
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00048AE0 File Offset: 0x00046CE0
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00006082 File Offset: 0x00004282
		public unsafe SelectionMessage selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00048B10 File Offset: 0x00046D10
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x000060A1 File Offset: 0x000042A1
		public unsafe Dictionary<string, IntentFitness> intents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_intents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IntentFitness>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_intents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00048B40 File Offset: 0x00046D40
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x000060C0 File Offset: 0x000042C0
		public unsafe List<IntentFitness> rankedIntents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_rankedIntents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntentFitness>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceContext.NativeFieldInfoPtr_rankedIntents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_offlineContext;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_intents;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_rankedIntents;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_SelectionMessage_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_IntentFor_Public_Int32_String_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_RankedIntentFor_Public_IntentFitness_String_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_fitnessFor_Protected_IntentFitness_String_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_IncrementFitnessFor_Public_Void_String_Int32_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_SelectionToString_Public_String_0;
	}
}
