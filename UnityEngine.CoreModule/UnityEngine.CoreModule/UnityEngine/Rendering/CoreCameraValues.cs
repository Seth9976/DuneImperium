using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022B RID: 555
	[StructLayout(2)]
	public struct CoreCameraValues
	{
		// Token: 0x06002537 RID: 9527 RVA: 0x0009EC08 File Offset: 0x0009CE08
		// Note: this type is marked as 'beforefieldinit'.
		static CoreCameraValues()
		{
			Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CoreCameraValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr);
			CoreCameraValues.NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "filterMode");
			CoreCameraValues.NativeFieldInfoPtr_cullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "cullingMask");
			CoreCameraValues.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "instanceID");
			CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100668091);
			CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100668092);
			CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100668093);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0009ECB0 File Offset: 0x0009CEB0
		[CallerCount(0)]
		public unsafe bool Equals(CoreCameraValues other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0009ECF0 File Offset: 0x0009CEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683365, XrefRangeEnd = 683368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0009ED34 File Offset: 0x0009CF34
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0000EB9E File Offset: 0x0000CD9E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, ref this));
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x0009ED64 File Offset: 0x0009CF64
		public static bool operator ==(CoreCameraValues left, CoreCameraValues right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0009ED80 File Offset: 0x0009CF80
		public static bool operator !=(CoreCameraValues left, CoreCameraValues right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeFieldInfoPtr_filterMode;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_cullingMask;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020DF RID: 8415
		[FieldOffset(0)]
		public int filterMode;

		// Token: 0x040020E0 RID: 8416
		[FieldOffset(4)]
		public uint cullingMask;

		// Token: 0x040020E1 RID: 8417
		[FieldOffset(8)]
		public int instanceID;
	}
}
