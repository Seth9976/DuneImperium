using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	[StructLayout(2)]
	public struct BlendShapeBufferRange
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x00051D58 File Offset: 0x0004FF58
		// Note: this type is marked as 'beforefieldinit'.
		static BlendShapeBufferRange()
		{
			Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BlendShapeBufferRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr);
			BlendShapeBufferRange.NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, "m_StartIndex");
			BlendShapeBufferRange.NativeFieldInfoPtr_m_EndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, "m_EndIndex");
			BlendShapeBufferRange.NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, 100665528);
			BlendShapeBufferRange.NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, 100665529);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00051E40 File Offset: 0x00050040
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00051DD8 File Offset: 0x0004FFD8
		public unsafe uint startIndex
		{
			get
			{
				return this.m_StartIndex;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendShapeBufferRange.NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00051E58 File Offset: 0x00050058
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x00051E0C File Offset: 0x0005000C
		public unsafe uint endIndex
		{
			get
			{
				return this.m_EndIndex;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendShapeBufferRange.NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00007408 File Offset: 0x00005608
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_m_StartIndex;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_m_EndIndex;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0;

		// Token: 0x04000E58 RID: 3672
		[FieldOffset(0)]
		public uint m_StartIndex;

		// Token: 0x04000E59 RID: 3673
		[FieldOffset(4)]
		public uint m_EndIndex;
	}
}
