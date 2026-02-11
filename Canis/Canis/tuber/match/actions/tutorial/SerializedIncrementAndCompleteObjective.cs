using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace tuber.match.actions.tutorial
{
	// Token: 0x02000015 RID: 21
	public class SerializedIncrementAndCompleteObjective : SerializedAction
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedIncrementAndCompleteObjective()
		{
			Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "tuber.match.actions.tutorial", "SerializedIncrementAndCompleteObjective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr);
			SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_ObjectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr, "ObjectiveID");
			SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_IncrementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr, "IncrementAmount");
			SerializedIncrementAndCompleteObjective.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr, 100663396);
			SerializedIncrementAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr, 100663397);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001C32C File Offset: 0x0001A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543585, XrefRangeEnd = 543589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedIncrementAndCompleteObjective.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0001C388 File Offset: 0x0001A588
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedIncrementAndCompleteObjective()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedIncrementAndCompleteObjective>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedIncrementAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002604 File Offset: 0x00000804
		public SerializedIncrementAndCompleteObjective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000260D File Offset: 0x0000080D
		public unsafe int ObjectiveID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_ObjectiveID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_ObjectiveID)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe int IncrementAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_IncrementAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedIncrementAndCompleteObjective.NativeFieldInfoPtr_IncrementAmount)) = value;
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_ObjectiveID;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_IncrementAmount;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
