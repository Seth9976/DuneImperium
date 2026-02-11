using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000005 RID: 5
	public class MeasureOutput : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000020E0 File Offset: 0x000002E0
		// Note: this type is marked as 'beforefieldinit'.
		static MeasureOutput()
		{
			Il2CppClassPointerStore<MeasureOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "MeasureOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeasureOutput>.NativeClassPtr);
			MeasureOutput.NativeMethodInfoPtr_Make_Public_Static_YogaSize_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureOutput>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0001CE78 File Offset: 0x0001B078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282406, RefRangeEnd = 282408, XrefRangeStart = 282406, XrefRangeEnd = 282406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaSize Make(float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureOutput.NativeMethodInfoPtr_Make_Public_Static_YogaSize_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002119 File Offset: 0x00000319
		public MeasureOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Make_Public_Static_YogaSize_Single_Single_0;
	}
}
