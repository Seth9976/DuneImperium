using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages.outgoing;

namespace Canis.entities.ai
{
	// Token: 0x020000F9 RID: 249
	public class AIChoice : Object
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00048260 File Offset: 0x00046460
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoice()
		{
			Il2CppClassPointerStore<AIChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoice>.NativeClassPtr);
			AIChoice.NativeFieldInfoPtr_AIDecisionDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, "AIDecisionDelay");
			AIChoice.NativeFieldInfoPtr_ConsecutiveSelectionLoopThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, "ConsecutiveSelectionLoopThreshold");
			AIChoice.NativeFieldInfoPtr__rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, "<rank>k__BackingField");
			AIChoice.NativeFieldInfoPtr__context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, "<context>k__BackingField");
			AIChoice.NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, "notes");
			AIChoice.NativeMethodInfoPtr_get_rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665690);
			AIChoice.NativeMethodInfoPtr_set_rank_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665691);
			AIChoice.NativeMethodInfoPtr_get_context_Public_get_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665692);
			AIChoice.NativeMethodInfoPtr__ctor_Public_Void_AIChoiceContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665693);
			AIChoice.NativeMethodInfoPtr_SendResponse_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665694);
			AIChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665695);
			AIChoice.NativeMethodInfoPtr_ResponseExpected_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665696);
			AIChoice.NativeMethodInfoPtr_SetRank_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665697);
			AIChoice.NativeMethodInfoPtr_colorNumber_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665698);
			AIChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoice>.NativeClassPtr, 100665699);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000483BC File Offset: 0x000465BC
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000483F8 File Offset: 0x000465F8
		public unsafe int rank
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr_get_rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr_set_rank_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00048438 File Offset: 0x00046638
		public unsafe AIChoiceContext context
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr_get_context_Public_get_AIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoiceContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00048478 File Offset: 0x00046678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 568210, RefRangeEnd = 568211, XrefRangeStart = 568208, XrefRangeEnd = 568210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoice(AIChoiceContext c, int r)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr__ctor_Public_Void_AIChoiceContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000484D4 File Offset: 0x000466D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568211, XrefRangeEnd = 568218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoice.NativeMethodInfoPtr_SendResponse_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00048510 File Offset: 0x00046710
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0004855C File Offset: 0x0004675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568218, XrefRangeEnd = 568224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ResponseExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoice.NativeMethodInfoPtr_ResponseExpected_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000485A4 File Offset: 0x000467A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRank(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr_SetRank_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000485E4 File Offset: 0x000467E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 568243, RefRangeEnd = 568250, XrefRangeStart = 568224, XrefRangeEnd = 568243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string colorNumber(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoice.NativeMethodInfoPtr_colorNumber_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00048628 File Offset: 0x00046828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568250, XrefRangeEnd = 568257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00005FB4 File Offset: 0x000041B4
		public AIChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0004866C File Offset: 0x0004686C
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00005FBD File Offset: 0x000041BD
		public unsafe static Nullable<int> AIDecisionDelay
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(AIChoice.NativeFieldInfoPtr_AIDecisionDelay, intPtr);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIChoice.NativeFieldInfoPtr_AIDecisionDelay, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000486A8 File Offset: 0x000468A8
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00005FD4 File Offset: 0x000041D4
		public unsafe static int ConsecutiveSelectionLoopThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AIChoice.NativeFieldInfoPtr_ConsecutiveSelectionLoopThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIChoice.NativeFieldInfoPtr_ConsecutiveSelectionLoopThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000486C4 File Offset: 0x000468C4
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00005FE2 File Offset: 0x000041E2
		public unsafe int _rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr__rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr__rank_k__BackingField)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000486EC File Offset: 0x000468EC
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00005FFD File Offset: 0x000041FD
		public unsafe AIChoiceContext _context_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr__context_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIChoiceContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr__context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0004871C File Offset: 0x0004691C
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x0000601C File Offset: 0x0000421C
		public unsafe string notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr_notes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoice.NativeFieldInfoPtr_notes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_AIDecisionDelay;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_ConsecutiveSelectionLoopThreshold;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr__rank_k__BackingField;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr__context_k__BackingField;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_notes;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_get_rank_Public_get_Int32_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_set_rank_Protected_set_Void_Int32_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_context_Public_get_AIChoiceContext_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIChoiceContext_Int32_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_SendResponse_Public_Virtual_New_Void_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_New_ISelectionCounter_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_ResponseExpected_Public_Virtual_New_Boolean_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_SetRank_Public_Void_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_colorNumber_Public_String_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
