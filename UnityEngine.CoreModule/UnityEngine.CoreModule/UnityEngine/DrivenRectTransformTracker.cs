using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000174 RID: 372
	[StructLayout(2)]
	public struct DrivenRectTransformTracker
	{
		// Token: 0x06001BD4 RID: 7124 RVA: 0x0007F1FC File Offset: 0x0007D3FC
		// Note: this type is marked as 'beforefieldinit'.
		static DrivenRectTransformTracker()
		{
			Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DrivenRectTransformTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100667085);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100667086);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0007F254 File Offset: 0x0007D454
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drivenProperties;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0007F2AC File Offset: 0x0007D4AC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0000AC3F File Offset: 0x00008E3F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, ref this));
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007F2D4 File Offset: 0x0007D4D4
		public static bool CanRecordModifications()
		{
			return true;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0000AC51 File Offset: 0x00008E51
		public void Clear(bool revertValues)
		{
			this.Clear();
		}

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
