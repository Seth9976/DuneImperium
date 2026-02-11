using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000166 RID: 358
	public static class ProjectionUtils : Object
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x0000BFFB File Offset: 0x0000A1FB
		// Note: this type is marked as 'beforefieldinit'.
		static ProjectionUtils()
		{
			Il2CppClassPointerStore<ProjectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ProjectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectionUtils>.NativeClassPtr);
			ProjectionUtils.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectionUtils>.NativeClassPtr, 100667157);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0007A874 File Offset: 0x00078A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322080, RefRangeEnd = 322081, XrefRangeStart = 322080, XrefRangeEnd = 322080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref far;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProjectionUtils.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000C034 File Offset: 0x0000A234
		public ProjectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;
	}
}
