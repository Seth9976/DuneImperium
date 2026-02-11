using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000237 RID: 567
	public class ObjectIdRequest : Object
	{
		// Token: 0x06002607 RID: 9735 RVA: 0x000A1B8C File Offset: 0x0009FD8C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectIdRequest()
		{
			Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ObjectIdRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr);
			ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr, "<destination>k__BackingField");
			ObjectIdRequest.NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr, 100668184);
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000A1BE4 File Offset: 0x0009FDE4
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x0000EE58 File Offset: 0x0000D058
		public unsafe RenderTexture destination
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIdRequest.NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			set
			{
				this._destination_k__BackingField = value;
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0000EE30 File Offset: 0x0000D030
		public ObjectIdRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000A1C24 File Offset: 0x0009FE24
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0000EE39 File Offset: 0x0000D039
		public unsafe RenderTexture _destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x0000EE61 File Offset: 0x0000D061
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x0000EE6E File Offset: 0x0000D06E
		public int mipLevel
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x0000EE7B File Offset: 0x0000D07B
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x0000EE88 File Offset: 0x0000D088
		public CubemapFace face
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0000EE95 File Offset: 0x0000D095
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x0000EEA2 File Offset: 0x0000D0A2
		public int slice
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		public ObjectIdResult result
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeFieldInfoPtr__destination_k__BackingField;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0;
	}
}
