using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.zen.match.renderer
{
	// Token: 0x0200004B RID: 75
	public class SetAnimatorBool : MonoBehaviour
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x0001A99C File Offset: 0x00018B9C
		// Note: this type is marked as 'beforefieldinit'.
		static SetAnimatorBool()
		{
			Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.zen.match.renderer", "SetAnimatorBool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr);
			SetAnimatorBool.NativeFieldInfoPtr_parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr, "parameter");
			SetAnimatorBool.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr, 100663814);
			SetAnimatorBool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr, 100663815);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001AA08 File Offset: 0x00018C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985491, XrefRangeEnd = 985499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimatorBool.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985499, XrefRangeEnd = 985503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAnimatorBool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAnimatorBool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimatorBool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000345E File Offset: 0x0000165E
		public SetAnimatorBool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0001AA78 File Offset: 0x00018C78
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00003467 File Offset: 0x00001667
		public unsafe string parameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimatorBool.NativeFieldInfoPtr_parameter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimatorBool.NativeFieldInfoPtr_parameter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_parameter;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
