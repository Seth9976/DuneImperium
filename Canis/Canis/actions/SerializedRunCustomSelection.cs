using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001D2 RID: 466
	[Serializable]
	public class SerializedRunCustomSelection : SerializedAction
	{
		// Token: 0x06001398 RID: 5016 RVA: 0x00068AE4 File Offset: 0x00066CE4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunCustomSelection()
		{
			Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedRunCustomSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr);
			SerializedRunCustomSelection.NativeFieldInfoPtr_SelectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr, "SelectedOption");
			SerializedRunCustomSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr, 100667569);
			SerializedRunCustomSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr, 100667570);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00068B50 File Offset: 0x00066D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunCustomSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00068BAC File Offset: 0x00066DAC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunCustomSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunCustomSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunCustomSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000098E3 File Offset: 0x00007AE3
		public SerializedRunCustomSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00068BE8 File Offset: 0x00066DE8
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000098EC File Offset: 0x00007AEC
		public unsafe int SelectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunCustomSelection.NativeFieldInfoPtr_SelectedOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunCustomSelection.NativeFieldInfoPtr_SelectedOption)) = value;
			}
		}

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOption;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
