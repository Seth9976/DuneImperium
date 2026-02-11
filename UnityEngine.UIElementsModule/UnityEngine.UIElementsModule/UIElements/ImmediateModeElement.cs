using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D3 RID: 723
	public abstract class ImmediateModeElement : VisualElement
	{
		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x000152B6 File Offset: 0x000134B6
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x000152C3 File Offset: 0x000134C3
		public bool cullingEnabled
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

		// Token: 0x0600340D RID: 13325 RVA: 0x000152D0 File Offset: 0x000134D0
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			mgc.painter.DrawImmediate(new Action(this.CallImmediateRepaint), this.cullingEnabled);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x000152F1 File Offset: 0x000134F1
		public void CallImmediateRepaint()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
