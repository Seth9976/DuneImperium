using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x02000018 RID: 24
	[StructLayout(2)]
	public struct ProfilerMarker
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0001842C File Offset: 0x0001662C
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerMarker()
		{
			Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr);
			ProfilerMarker.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "m_Ptr");
			ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663366);
			ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663367);
			ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663368);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000184AC File Offset: 0x000166AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643180, XrefRangeEnd = 643182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000184E4 File Offset: 0x000166E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643182, XrefRangeEnd = 643184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker(ProfilerCategory category, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00018528 File Offset: 0x00016728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643184, XrefRangeEnd = 643187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker.AutoScope Auto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000258C File Offset: 0x0000078C
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, ref this));
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000259E File Offset: 0x0000079E
		public IntPtr Handle
		{
			get
			{
				return this.m_Ptr;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000025A6 File Offset: 0x000007A6
		public void Begin()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.BeginSample(this.m_Ptr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000025B5 File Offset: 0x000007B5
		public void Begin(global::UnityEngine.Object contextUnityObject)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, contextUnityObject);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000025C5 File Offset: 0x000007C5
		public void End()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.EndSample(this.m_Ptr);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000025D4 File Offset: 0x000007D4
		public void GetName(ref string name)
		{
			name = Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Auto_Public_AutoScope_0;

		// Token: 0x0400007D RID: 125
		[NonSerialized]
		[FieldOffset(0)]
		public readonly IntPtr m_Ptr;

		// Token: 0x02000398 RID: 920
		[StructLayout(2)]
		public struct AutoScope
		{
			// Token: 0x0600300D RID: 12301 RVA: 0x000B688C File Offset: 0x000B4A8C
			// Note: this type is marked as 'beforefieldinit'.
			static AutoScope()
			{
				Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "AutoScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr);
				ProfilerMarker.AutoScope.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, "m_Ptr");
				ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, 100663370);
			}

			// Token: 0x0600300E RID: 12302 RVA: 0x000B68E0 File Offset: 0x000B4AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643177, XrefRangeEnd = 643180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600300F RID: 12303 RVA: 0x0001371C File Offset: 0x0001191C
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, ref this));
			}

			// Token: 0x04002ACF RID: 10959
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04002AD0 RID: 10960
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002AD1 RID: 10961
			[FieldOffset(0)]
			public readonly IntPtr m_Ptr;
		}
	}
}
